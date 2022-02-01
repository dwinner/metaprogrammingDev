using System;
using System.Text;

namespace LL1_RecursiveDescentLexer
{
   public class ListLexer : Lexer
   {
      private const int Name = 2;
      private const int Comma = 3;
      private const int Lbrack = 4;
      private const int Rbrack = 5;

      public static readonly string[] TokenNames =
      {
         "n/a",
         "<EOF>",
         "NAME",
         "COMMA",
         "LBRACK",
         "RBRACK"
      };

      public ListLexer(string input) : base(input)
      {
      }

      public override Token GetNextToken()
      {
         while (CurrentChar != Eof)
         {
            switch (CurrentChar)
            {
               case ' ':
               case '\t':
               case '\n':
               case '\r':
                  EatWhitespace();
                  continue;
               case ',':
                  Consume();
                  return new Token(Comma, ",");
               case '[':
                  Consume();
                  return new Token(Lbrack, "[");
               case ']':
                  Consume();
                  return new Token(Rbrack, "]");
               default:
                  if (IsLetter())
                  {
                     return GetNameToken();
                  }

                  throw new Exception($"invalid character: {CurrentChar}");
            }
         }

         return new Token(EofType, "<EOF>");
      }

      public override string GetTokenName(int tokenType) => TokenNames[tokenType];

      private bool IsLetter() => CurrentChar >= 'a' && CurrentChar <= 'z' || CurrentChar >= 'A' && CurrentChar <= 'Z';

      /// <summary>
      ///    Get sequence of >=1 letter
      /// </summary>
      /// <returns>Name token</returns>
      private Token GetNameToken()
      {
         var buf = new StringBuilder();
         do
         {
            buf.Append(CurrentChar);
            Consume();
         } while (IsLetter());

         return new Token(Name, buf.ToString());
      }

      /// <summary>
      ///    Ignore any whitespace
      /// </summary>
      private void EatWhitespace()
      {
         while (CurrentChar == ' ' || CurrentChar == '\t' || CurrentChar == '\n' || CurrentChar == '\r')
         {
            Consume();
         }
      }
   }
}