using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using static System.Console;

namespace PrintingSolutionSample
{
   internal static class Program
   {
      private static readonly Solution _Solution =
         MSBuildWorkspace.Create().OpenSolutionAsync(@"..\..\..\Playground\Playground.sln").Result;      

      private static void Main()
      {
         // ������ �������
         WriteLine(Path.GetFileName(_Solution.FilePath));

         // ���� ������������
         var dependencyGraph = _Solution.GetProjectDependencyGraph();
         var sortedProjects = dependencyGraph.GetTopologicallySortedProjects();

         // ��� �������, ���������, � ������
         foreach (var project in sortedProjects.Select(projectId => _Solution.GetProject(projectId)))
         {
            WriteLine("> {0}", project.Name);
            WriteLine("  > References");
            foreach (var projectReference in project.ProjectReferences)
            {
               WriteLine("     - {0}", _Solution.GetProject(projectReference.ProjectId).Name);
            }

            WriteLine("  > Documents");
            foreach (var document in project.Documents)
            {
               WriteLine("   - {0}", document.Name);
            }
         }
      }
   }
}