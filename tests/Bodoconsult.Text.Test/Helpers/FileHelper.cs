// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.IO;
using System.Reflection;

namespace Bodoconsult.Text.Test.Helpers;

internal class FileHelper
{

    static FileHelper()
    {
        AppPath = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.Parent.Parent.Parent.FullName;
        TestDataPath = Path.Combine(AppPath, "TestData");
    }

    public static string AppPath { get; }

    public static string TestDataPath { get; }
}