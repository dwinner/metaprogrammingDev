using System;
using System.Text;

namespace LL1_RecursiveDescentParser
{
   public class ListLexer : Lexer
   {
      public const int Name = 2;
      public const int Comma = 3;
      public const int Lbrack = 4;
      public const int Rbrack = 5;

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

      public override string GetTokenName(int x) => TokenNames[x];

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
                  EatWs();
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
                     return GetName();
                  }

                  throw new Exception($"Invalid character: {CurrentChar}");
            }
         }

         return new Token(EofType, "<EOF>");
      }

      /// <summary>
      ///    NAME : LETTER+ ; NAME is sequence of >=1 letter
      /// </summary>
      /// <returns>Token</returns>
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
      ///    LETTER   : 'a'..'z'|'A'..'Z'; define what a letter is (\w)
      /// </summary>
      /// <exception cref="Exception"></exception>
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
      ///    WS : (' '|'\t'|'\n'|'\r')* ; // ignore any whitespace
      /// </summary>
      private void EatWs()
      {
         while (CurrentChar == ' ' || CurrentChar == '\t' || CurrentChar == '\n' || CurrentChar == '\r')
         {
            Consume();
         }
      }
   }
}