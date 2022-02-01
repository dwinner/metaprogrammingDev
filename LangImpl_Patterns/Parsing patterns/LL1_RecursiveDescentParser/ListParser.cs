using System;

namespace LL1_RecursiveDescentParser
{
   public class ListParser : Parser
   {
      public ListParser(Lexer lexer) : base(lexer)
      {
      }

      /// <summary>
      ///    list : '[' elements ']' ; // match bracketed list
      /// </summary>
      public void ProcessList()
      {
         Match(ListLexer.Lbrack);
         ProcessElements();
         Match(ListLexer.Rbrack);
      }

      /// <summary>
      ///    elements : element (',' element)* ;
      /// </summary>
      private void ProcessElements()
      {
         ProcessElement();
         while (Lookahead.Type == ListLexer.Comma)
         {
            Match(ListLexer.Comma);
            ProcessElement();
         }
      }

      /// <summary>
      ///    Element : name | list ; // element is name or nested list
      /// </summary>
      /// <exception cref="Exception"></exception>
      private void ProcessElement()
      {
         switch (Lookahead.Type)
         {
            case ListLexer.Name:
               Match(ListLexer.Name);
               break;
            case ListLexer.Lbrack:
               ProcessList();
               break;
            default:
               throw new Exception($"expecting name or list; found {Lookahead}");
         }
      }
   }
}