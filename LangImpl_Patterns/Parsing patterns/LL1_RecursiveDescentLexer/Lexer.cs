using System;

namespace LL1_RecursiveDescentLexer
{
   public abstract class Lexer
   {
      protected const int Eof = -1;
      public const int EofType = 1;
      private readonly string _input; // input string
      private int _currentIndex; // index into input of current character
      protected int CurrentChar;

      protected Lexer(string input)
      {
         _input = input;
         CurrentChar = _input[_currentIndex]; // prime lookahead
      }

      /// <summary>
      ///    Move one character; detect "end of file"
      /// </summary>
      protected void Consume()
      {
         _currentIndex++;
         CurrentChar = _currentIndex >= _input.Length ? Eof : _input[_currentIndex];
      }

      /// <summary>
      ///    Ensure <paramref name="next" /> is the next character on the input stream
      /// </summary>
      /// <param name="next">The next character</param>
      public void Match(int next)
      {
         if (CurrentChar == next)
         {
            Consume();
         }
         else
         {
            throw new Exception($"Expecting {next}; found {CurrentChar}");
         }
      }

      public abstract Token GetNextToken();

      public abstract string GetTokenName(int tokenType);
   }
}