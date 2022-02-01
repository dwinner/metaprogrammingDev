namespace LL1_RecursiveDescentLexer
{
   public struct Token
   {
      public Token(int type, string text)
      {
         Type = type;
         Text = text;
      }

      public int Type { get; }

      public string Text { get; }

      public override string ToString()
      {
         var tokenName = ListLexer.TokenNames[Type];
         return $"<'{Text}',{tokenName}>";
      }
   }
}