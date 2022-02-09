using System;
using System.Text;

namespace LLK_RecursiveDescentParser
{
   public class LookaheadLexer : Lexer
   {
      internal const int Name = 2;
      internal const int Comma = 3;
      internal const int Lbrack = 4;
      internal const int Rbrack = 5;
      internal const int EqualsType = 6;

      public static readonly string[] TokenNames =
      {
         "n/a",
         "<EOF>",
         "NAME",
         ",",
         "[",
         "]",
         "="
      };

      public LookaheadLexer(string input) : base(input)
      {
      }

      public override string GetTokenName(int tokenIndex) => TokenNames[tokenIndex];

      private bool IsLetter() =>
         CurrentChar >= 'a' && CurrentChar <= 'z' || CurrentChar >= 'A' && CurrentChar <= 'Z';

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
                  EatWhitespaces();
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
               case '=':
                  Consume();
                  return new Token(EqualsType, "=");
               default:
                  if (IsLetter())
                  {
                     return GetName();
                  }

                  throw new Exception("invalid character: " + CurrentChar);
            }
         }

         return new Token(EofType, "<EOF>");
      }

      /// <summary>
      ///    name : LETTER+ ; name is sequence of >=1 letter
      /// </summary>
      /// <returns>Get name token</returns>
      private Token GetName()
      {
         var buf = new StringBuilder();
         do
         {
            buf.Append(CurrentChar);
            GetLetter();
         } while (IsLetter());

         return new Token(Name, buf.ToString());
      }

      /// <summary>
      ///    LETTER   : 'a'..'z'|'A'..'Z'; // define what a letter is (\w)
      /// </summary>
      private void GetLetter()
      {
         if (IsLetter())
         {
            Consume();
         }
         else
         {
            throw new Exception($"expecting LETTER; found {CurrentChar}");
         }
      }

      /// <summary>
      ///    WS : (' '|'\t'|'\n'|'\r')* ; ignore any whitespace
      /// </summary>
      protected override void EatWhitespaces()
      {
         while (CurrentChar == ' ' || CurrentChar == '\t' || CurrentChar == '\n' || CurrentChar == '\r')
         {
            Advance();
         }
      }
   }
}