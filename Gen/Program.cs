using SourceBrowser;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Gen
{
    class Program
    {
        public static void Main(string[] args)
        {
             if (Debugger.IsAttached) {
                ProgramLoad.isDebug = true;
                // DebugConsole.Redirect();
                ConsoleOut.SetOut();

                Console.WriteLine("Testing VS 2019 console....");
            }

            var sln = @"c:\Beta\dotnet\referencesource\referencesource.sln";

            var baseDir = Path.GetDirectoryName(sln);

            ProgramLoad.isDebug = false;
            ProgramLoad.BasePath = typeof(ProgramLoad).Assembly.Location;

            var dll = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Microsoft.SourceBrowser.Common.dll");
            Assembly.LoadFile(dll);

            if (!Debugger.IsAttached)
            {
                ProgramLoad.isDebug = false;
                ProgramLoad.Main(new string[] { ".exe", sln, $"/out:{baseDir}\\srcWeb" });
            } else
            {
                ProgramLoad.isDebug = true;
                ProgramLoad.Main(new string[] { sln, "/debug", $"/out:{baseDir}\\srcWeb" });
            }
        }
    }
}
