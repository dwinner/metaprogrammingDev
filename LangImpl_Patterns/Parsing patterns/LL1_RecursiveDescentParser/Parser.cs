using System;

namespace LL1_RecursiveDescentParser
{
   public abstract class Parser
   {
      private readonly Lexer _lexer; // from where do we get tokens?
      protected Token Lookahead; // the current lookahead token

      protected Parser(Lexer lexer)
      {
         _lexer = lexer;
         Consume();
      }

      /// <summary>
      ///    If lookahead token type matches x, consume & return else error
      /// </summary>
      /// <param name="nextToken">Next token</param>
      /// <exception cref="Exception"></exception>
      protected void Match(int nextToken)
      {
         if (Lookahead.Type == nextToken)
         {
            Consume();
         }
         else
         {
            throw new Exception($"Expecting {_lexer.GetTokenName(nextToken)}; found {Lookahead}");
         }
      }

      private void Consume() => Lookahead = _lexer.GetNextToken();
   }
}