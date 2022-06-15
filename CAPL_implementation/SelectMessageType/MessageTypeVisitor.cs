using System;
using System.Collections.Generic;
using System.Linq;
using CaplGrammar.Core;

namespace SelectMessageType
{
    internal class MessageTypeVisitor : CaplBaseVisitor<int>
    {
        public Dictionary<string, List<string>> MessageVariables { get; } = new Dictionary<string, List<string>>();

        public override int VisitDeclaration(CaplParser.DeclarationContext context)
        {
            var messageType = string.Empty;

            var declSpecCtx = context.declarationSpecifiers()?.declarationSpecifier();
            if (declSpecCtx != null)
            {
                // Find the type specifier in declaration specifier list
                var typeSpecCtx = declSpecCtx
                    .Select(specifierCtx => specifierCtx.typeSpecifier())
                    .FirstOrDefault(typeSpecifierContext => typeSpecifierContext != null);

                // If the type has a message type then it's a message
                var messageTypeCtx = typeSpecCtx?.messageType();
                if (messageTypeCtx != null)
                {
                    // Filter it's type for only 'Message' lexer rule
                    var trivialMessage = messageTypeCtx.Message();
                    if (trivialMessage == null)
                    {
                        return base.VisitDeclaration(context);
                    }

                    var children = messageTypeCtx.children;

                    /* According to the parser rule messageType in Capl.g4, the 1st child is always keyword
                       containing alternatives for lexer rules: Message, MultiplexedMessage, MostMessage or MostAmsMessage,
                       so the other items can gather the raw representation for message ID */
                    if (children.Count > 1)
                    {
                        messageType = children.Skip(1).Aggregate("",
                            (current, treeItem) => current + treeItem.ToString().Trim());
                    }
                }
            }

            /* If we find the message name under the related parser rule 'declaration'
               then can get it's message name instances */
            if (string.IsNullOrEmpty(messageType))
            {
                return base.VisitDeclaration(context);
            }

            if (!MessageVariables.ContainsKey(messageType))
            {
                MessageVariables[messageType] = new List<string>();
            }

            var initDeclCtx = context.initDeclaratorList()?.initDeclarator()
                              ?? Array.Empty<CaplParser.InitDeclaratorContext>();
            if (initDeclCtx.Length > 0)
            {
                var messageVars = initDeclCtx
                    .Select(initDecl =>
                        initDecl.declarator()?.directDeclarator()?.Identifier()?.Symbol.Text ?? string.Empty)
                    .Where(messageName => !string.IsNullOrEmpty(messageName)).ToList();
                MessageVariables[messageType].AddRange(messageVars);
            }

            return base.VisitDeclaration(context);
        }
    }
}