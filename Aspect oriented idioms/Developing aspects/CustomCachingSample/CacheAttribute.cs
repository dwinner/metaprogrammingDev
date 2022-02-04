namespace CustomCachingSample
{
   using System.Runtime.Caching;
   using System.Text;

   using Aop.Lib;

   using PostSharp.Aspects;
   using PostSharp.Serialization;

   /// <summary>
   ///    ���������������� �������, ����� ����������� � ������, �������� ������������
   ///    �������� ������, � ����������� �� ���������� �������� ����������
   /// </summary>
   [PSerializable]
   public sealed class CacheAttribute : OnMethodBoundaryAspect
   {
      /// <summary>
      ///    �����, ������� ����������� <i>�����</i> ������� ������� �������
      /// </summary>
      /// <param name="args">�������� ���������� ������</param>
      public override void OnEntry(MethodExecutionArgs args)
      {
         // �������� ���� ����
         var stringBuilder = new StringBuilder();
         stringBuilder.AppendCallInformation(args);         
         string cacheKey = stringBuilder.ToString();

         // ������� �������� �� ����
         object cachedValue = MemoryCache.Default.Get(cacheKey);
         if (cachedValue != null)
         {
            // ���� �������� ��� ���� ������������, �� ��������� �����. ������������� ������������ �������� �� ���� � ���������� �������
            args.ReturnValue = cachedValue;
            args.FlowBehavior = FlowBehavior.Return;
         }
         else
         {
            // ���� �������� �� ������������, ���������� ���������, �� ��������� ���� ���� ��� ���������� �������������
            args.MethodExecutionTag = cacheKey;
            args.FlowBehavior = FlowBehavior.Continue;
         }
      }

      /// <summary>
      ///    �����, ������� ����������� <i>�����</i> �������� ������ �������
      /// </summary>
      /// <param name="args">�������� ���������� ������</param>
      public override void OnSuccess(MethodExecutionArgs args)
      {
         var cacheKey = (string) args.MethodExecutionTag;
         MemoryCache.Default[cacheKey] = args.ReturnValue;
      }
   }
}