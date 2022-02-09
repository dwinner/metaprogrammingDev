using System;

namespace LLK_RecursiveDescentParser
{
   public class LookaheadParser : Parser
   {
      public LookaheadParser(Lexer input, int lookaheadCount)
         : base(input, lookaheadCount)
      {
      }

      /// <summary>
      ///    list : '[' elements ']' ; match bracketed list
      /// </summary>
      public void ProcessList()
      {
         Match(LookaheadLexer.Lbrack);
         ProcessElements();
         Match(LookaheadLexer.Rbrack);
      }

      /// <summary>
      ///    elements : element (',' element)* ; match comma-separated list
      /// </summary>
      private void ProcessElements()
      {
         ProcessElement();
         while (La(1) == LookaheadLexer.Comma)
         {
            Match(LookaheadLexer.Comma);
            ProcessElement();
         }
      }

      /// <summary>
      ///    element : NAME '=' NAME | NAME | list ; assignment, NAME or list
      /// </summary>
      private void ProcessElement()
      {
         if (La(1) == LookaheadLexer.Name && La(2) == LookaheadLexer.EqualsType)
         {
            Match(LookaheadLexer.Name);
            Match(LookaheadLexer.EqualsType);
            Match(LookaheadLexer.Name);
         }
         else if (La(1) == LookaheadLexer.Name)
         {
            Match(LookaheadLexer.Name);
         }
         else if (La(1) == LookaheadLexer.Lbrack)
         {
            ProcessList();
         }
         else
         {
            throw new Exception($"expecting name or list; found {Lt(1)}");
         }
      }
   }
}