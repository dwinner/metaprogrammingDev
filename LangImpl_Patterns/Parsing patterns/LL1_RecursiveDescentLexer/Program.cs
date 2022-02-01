/*
 * LL(1) can "eat" the string like this: "[a, b ]"
 */

using System;

namespace LL1_RecursiveDescentLexer
{
   internal static class Program
   {
      private static void Main(string[] args)
      {
         var lexer = new ListLexer(args[0]);
         var nextToken = lexer.GetNextToken();
         while (nextToken.Type != Lexer.EofType)
         {
            Console.WriteLine(nextToken);
            nextToken = lexer.GetNextToken();
         }

         Console.WriteLine();
      }
   }
}