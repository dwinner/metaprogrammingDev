namespace LL1_RecursiveDescentParser
{
   public class Token
   {
      public Token(int type, string text)
      {
         Type = type;
         Text = text;
      }

      private string Text { get; }

      public int Type { get; }

      public override string ToString()
      {
         var tname = ListLexer.TokenNames[Type];
         return $"<'{Text}',{tname}>";
      }
   }
}