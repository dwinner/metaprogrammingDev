using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Rename;

namespace RenamingSample
{
   static class Program
   {
      private static readonly Solution _Solution =
         MSBuildWorkspace.Create().OpenSolutionAsync(@"..\..\..\Playground\Playground.sln").Result;

      static void Main()
      {
         var oldProject = _Solution.Projects.Single(p => p.Name == "ConfigureAwaitTest");
         var oldDocument = oldProject.Documents.Single(d => d.Name == "Bar.cs");

         Console.WriteLine("Before:");
         Console.WriteLine();

         var oldTxt = oldDocument.GetTextAsync().Result;
         Console.WriteLine(oldTxt);

         Console.WriteLine();
         Console.WriteLine();

         // ������� ������ ��� ������ Bar.Foo
         var compilation = oldProject.GetCompilationAsync().Result;
         var barType = compilation.GetTypeByMetadataName("Workspaces.Bar");
         var fooMethod = barType.GetMembers().Single(m => m.Name == "Foo");

         // ����������� ������ ���������, �� ���� �������
         var newSolution = Renamer.RenameSymbolAsync(_Solution, fooMethod, "Foo2", _Solution.Workspace.Options).Result;

         // ������� Bar.cs ����� ��������������
         var newProject = newSolution.Projects.Single(p => p.Name == "ConfigureAwaitTest");
         var newDocument = newProject.Documents.Single(d => d.Name == "Bar.cs");

         Console.WriteLine("After:");
         Console.WriteLine();

         var newText = newDocument.GetTextAsync().Result;
         Console.WriteLine(newText);
      }
   }
}