namespace LL1_RecursiveDescentParser
{
   internal static class Program
   {
      private static void Main(string[] args)
      {
         var lexer = new ListLexer(args[0]); // parse command-line arg
         var parser = new ListParser(lexer);
         parser.ProcessList(); // begin parsing at rule list
      }
   }
}