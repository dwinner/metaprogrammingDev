namespace LLK_RecursiveDescentParser
{
   public class Token
   {
      private readonly string _text;

      public Token(int type, string text)
      {
         Type = type;
         _text = text;
      }

      public int Type { get; }

      public override string ToString()
      {
         var tname = LookaheadLexer.TokenNames[Type];
         return $"<'{_text}',{tname}>";
      }
   }
}