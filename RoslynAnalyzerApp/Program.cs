using System.IO;

namespace RoslynAnalyzerApp
{
    internal class Program
    {
        private static readonly string DummySolutionPath = @"C:\git\RoslynAnalyzerApp\SampleDesktopApp";

        public static void Main(string[] args)
        {
            var files = Directory.EnumerateFiles(DummySolutionPath, "*.cs");
        }
    }
}