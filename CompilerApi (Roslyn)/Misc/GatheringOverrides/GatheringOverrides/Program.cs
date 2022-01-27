using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using MoreLinq;

namespace GatheringOverrides
{
   internal static class Program
   {
      private const string Indentation = "    ";

      // ReSharper disable once AsyncConverter.AsyncMethodNamingHighlighting
      private static async Task Main(string[] args)
      {
         // Attempt to set the version of MSBuild.
         var visualStudioInstances = MSBuildLocator.QueryVisualStudioInstances().ToArray();
         var instance = visualStudioInstances.Length == 1
            ? visualStudioInstances
               [0] // If there is only one instance of MSBuild on this machine, set that as the one to use.                                       
            : SelectVisualStudioInstance(
               visualStudioInstances); // Handle selecting the version of MSBuild you want to use.

         Console.WriteLine($"Using MSBuild at '{instance.MSBuildPath}' to load projects.");

         // NOTE: Be sure to register an instance with the MSBuildLocator
         //       before calling MSBuildWorkspace.Create()
         //       otherwise, MSBuildWorkspace won't MEF compose.
         MSBuildLocator.RegisterInstance(instance);

         using (var workspace = MSBuildWorkspace.Create())
         {
            // Print message for WorkspaceFailed event to help diagnosing project load failures.
            workspace.WorkspaceFailed += (o, e) => Console.WriteLine(e.Diagnostic.Message);
            if (args.Length == 0)
            {
               Console.WriteLine("Usage: Program Path_To_Solution");
               return;
            }

            var solutionPath = args[0];
            Console.WriteLine($"Loading solution '{solutionPath}'");

            // Attach progress reporter so we print projects as they are loaded.
            var solution = await workspace.OpenSolutionAsync(solutionPath, new ConsoleProgressReporter())
               .ConfigureAwait(false);
            Console.WriteLine($"Finished loading solution '{solutionPath}'");

            // Gathering overrides of the desired type
            var projectToFind = solution.Projects.FirstOrDefault(project => project.Name == "WpfApp");
            var documentToFind =
               projectToFind?.Documents.FirstOrDefault(document => document.Name == "MainWindow.xaml.cs");
            if (documentToFind != null)
            {
               var model = await documentToFind.GetSemanticModelAsync().ConfigureAwait(false);
               var root = await documentToFind.GetSyntaxRootAsync().ConfigureAwait(false);
               var classToFind = root.DescendantNodes(_ => true)
                  .OfType<ClassDeclarationSyntax>()
                  .FirstOrDefault(classDecl => classDecl.Identifier.ToString() == "MainWindow");

               if (classToFind != null)
               {
                  IOverridableCollector collector = new DefaultOverridableCollector(classToFind, model);
                  var methods = collector.GatherMethods(TypeHierarchyFilter.All, Indentation.Repeat(2));
                  var properties = collector.GatherProperties(TypeHierarchyFilter.All, Indentation.Repeat(2));
                  methods.ForEach(entry => Console.WriteLine(entry));
                  properties.ForEach(entry => Console.WriteLine(entry));                  
               }
            }
         }
      }

      private static VisualStudioInstance SelectVisualStudioInstance(
         IReadOnlyList<VisualStudioInstance> visualStudioInstances)
      {
         Console.WriteLine("Multiple installs of MSBuild detected please select one:");
         for (var i = 0; i < visualStudioInstances.Count; i++)
         {
            Console.WriteLine($"Instance {i + 1}");
            Console.WriteLine($"    Name: {visualStudioInstances[i].Name}");
            Console.WriteLine($"    Version: {visualStudioInstances[i].Version}");
            Console.WriteLine($"    MSBuild Path: {visualStudioInstances[i].MSBuildPath}");
         }

         while (true)
         {
            var userResponse = Console.ReadLine();
            if (int.TryParse(userResponse, out var instanceNumber) &&
                instanceNumber > 0 &&
                instanceNumber <= visualStudioInstances.Count)
            {
               return visualStudioInstances[instanceNumber - 1];
            }

            Console.WriteLine("Input not accepted, try again.");
         }
      }

      private sealed class ConsoleProgressReporter : IProgress<ProjectLoadProgress>
      {
         public void Report(ProjectLoadProgress loadProgress)
         {
            var projectDisplay = Path.GetFileName(loadProgress.FilePath);
            if (loadProgress.TargetFramework != null)
            {
               projectDisplay += $" ({loadProgress.TargetFramework})";
            }

            Console.WriteLine(
               $"{loadProgress.Operation,-15} {loadProgress.ElapsedTime,-15:m\\:ss\\.fffffff} {projectDisplay}");
         }
      }
   }
}