/*
 * Lookahead for K-tokens
 * Input: [a,b=c,[d,e]]
 */

namespace LLK_RecursiveDescentParser
{
   internal static class Program
   {
      private static void Main(string[] args)
      {
         var lexer = new LookaheadLexer(args[0]); // parse arg
         var parser = new LookaheadParser(lexer, 2);
         parser.ProcessList(); // begin parsing at rule list
      }
   }
}