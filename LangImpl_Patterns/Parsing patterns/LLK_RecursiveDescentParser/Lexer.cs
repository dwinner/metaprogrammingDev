using System;

namespace LLK_RecursiveDescentParser
{
   public abstract class Lexer
   {
      protected const int Eof = -1; // represent end of file char
      protected const int EofType = 1; // represent EOF token type
      private readonly string _input; // input string
      private int _charIndex; // index into input of current character
      protected int CurrentChar; // current character

      protected Lexer(string input)
      {
         _input = input;
         CurrentChar = input[_charIndex]; // prime lookahead
      }

      /// <summary>
      ///    Move to next non-whitespace character
      /// </summary>
      protected void Consume()
      {
         Advance();
         EatWhitespaces();
      }

      protected void Advance()
      {
         _charIndex++;
         CurrentChar = _charIndex >= _input.Length ? Eof : _input[_charIndex];
      }

      public void Match(char next)
      {
         if (CurrentChar == next)
         {
            Consume();
         }
         else
         {
            throw new Exception($"expecting {next}; found {CurrentChar}");
         }
      }

      public abstract Token GetNextToken();

      protected abstract void EatWhitespaces();

      public abstract string GetTokenName(int tokenIndex);
   }
}