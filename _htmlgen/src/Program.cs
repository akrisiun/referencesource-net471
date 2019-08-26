using System;
using System.IO;
using SourceBrowser;

namespace htmlgen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ProgramLoad.isDebug = true;

            //var corlib = @"D:\Beta\dotnet\Manifest\referencesource\mscorlib";
            //var csproj = "mscorlib.csproj";
            // Directory.SetCurrentDirectory(corlib);
            // var exe = @"C:\bin\tools\htmlgen\HtmlGenerator.exe /out:srcweb $csproj";

            var sln = @"D:\Beta\dotnet\Manifest";
            var slnFile = "RuntimePortable.Source.sln";
            var exe = $@"C:\bin\tools\htmlgen\HtmlGenerator.exe /out:srcweb2 {slnFile}";
            Console.WriteLine(exe);
            Directory.SetCurrentDirectory(sln);

            ProgramLoad.Main(new string[] { "/out:srcweb2", slnFile });
            
            Console.WriteLine("END!");
            Console.ReadKey();
        }
    }
}
