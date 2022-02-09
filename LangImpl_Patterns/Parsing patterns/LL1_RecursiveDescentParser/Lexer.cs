using System;

namespace LL1_RecursiveDescentParser
{
   public abstract class Lexer
   {
      protected const int Eof = -1; //  represent end of file char
      protected const int EofType = 1; //  represent EOF token type
      private readonly string _input; // input string
      private int _inputIndex; // index into input of current character
      protected int CurrentChar; // current character

      protected Lexer(string input)
      {
         _input = input;
         CurrentChar = input[_inputIndex]; // prime lookahead
      }

      /// <summary>
      ///    Move one character; detect "end of file"
      /// </summary>
      protected void Consume()
      {
         _inputIndex++;
         CurrentChar = _inputIndex >= _input.Length ? Eof : _input[_inputIndex];
      }

      /// <summary>
      ///    Ensure <paramref name="next" /> is next character on the input stream
      /// </summary>
      /// <param name="next">The next char</param>
      /// <exception cref="Exception"></exception>
      public void Match(char next)
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