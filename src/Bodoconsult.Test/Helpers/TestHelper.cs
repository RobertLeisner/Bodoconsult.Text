// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Bodoconsult.Test.Helpers
{
    public class TestHelper
    {

        static TestHelper()
        {
            AppPath = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.Parent.Parent.Parent.FullName;
            TestDataPath = Path.Combine(AppPath, "TestData");
        }

        public static string AppPath { get; }

        public static string TestDataPath { get; }


        /// <summary>
        /// Get a text from an embedded resource file
        /// </summary>
        /// <param name="resourceName">resource name = plain file name without extension and path</param>
        /// <returns></returns>
        internal static string GetTextResource(string resourceName)
        {

            resourceName = $"Bodoconsult.Test.Resources.{resourceName}.txt";

            var ass = Assembly.GetExecutingAssembly();
            var str = ass.GetManifestResourceStream(resourceName);

            if (str == null) return null;

            string s;

            using (var file = new StreamReader(str))
            {
                s = file.ReadToEnd();
            }

            return s;
        }

        /// <summary>
        /// Opens a file in a separate process. Executable not required
        /// </summary>
        /// <param name="path">File to open</param>
        public static void OpenFile(string path)
        {

            if (!Debugger.IsAttached) return;

            var p = new Process
            {
                StartInfo = new ProcessStartInfo(path)
                {
                    UseShellExecute = true
                }
            };
            p.Start();
        }

    }
}
