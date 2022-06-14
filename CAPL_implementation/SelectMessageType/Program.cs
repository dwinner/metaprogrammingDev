using System;
using System.Text;
using Antlr4.Runtime;
using CaplGrammar.Core;

namespace SelectMessageType
{
    internal static class Program
    {
        private const string CanFile = "message.can";

        private static void Main()
        {
            AntlrInputStream antlrStream = new AntlrFileStream(CanFile, Encoding.UTF8);
            var caplLexer = new CaplLexer(antlrStream);
            var tokens = new CommonTokenStream(caplLexer);
            var caplParser = new CaplParser(tokens) { BuildParseTree = true };
            var caplAst = caplParser.compilationUnit();

            var messageTypeVisitor = new MessageTypeVisitor();
            messageTypeVisitor.Visit(caplAst);
            var messageVariables = messageTypeVisitor.MessageVariables;

            Console.WriteLine();
        }
    }
}