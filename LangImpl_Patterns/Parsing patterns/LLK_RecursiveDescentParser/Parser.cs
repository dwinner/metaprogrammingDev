using System;

namespace LLK_RecursiveDescentParser
{
   public abstract class Parser
   {
      private readonly Lexer _input; // from where do we get tokens?
      private readonly Token[] _lookaheadBuffer; // circular lookahead buffer
      private readonly int _lookaheadCount; // how many lookahead symbols
      private int _circularIndex; // circular index of next token position to fill

      protected Parser(Lexer input, int lookaheadCount)
      {
         _input = input;
         _lookaheadCount = lookaheadCount;
         _lookaheadBuffer = new Token[lookaheadCount]; // make lookahead buffer
         for (var i = 1; i <= lookaheadCount; i++)
         {
            Consume(); // prime buffer with k lookahead
         }
      }

      private void Consume()
      {
         _lookaheadBuffer[_circularIndex] = _input.GetNextToken(); // fill next position with token
         _circularIndex = (_circularIndex + 1) % _lookaheadCount; // increment circular index
      }

      protected Token Lt(int i) => _lookaheadBuffer[(_circularIndex + i - 1) % _lookaheadCount]; // circular fetch

      protected int La(int i) => Lt(i).Type;

      protected void Match(int x)
      {
         if (La(1) == x)
         {
            Consume();
         }
         else
         {
            throw new Exception($"expecting {_input.GetTokenName(x)}; found {Lt(1)}");
         }
      }
   }
}