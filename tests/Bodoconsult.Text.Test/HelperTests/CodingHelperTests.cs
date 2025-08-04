// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using Microsoft.VisualBasic;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Bodoconsult.Text.Test.HelperTests;

[TestFixture]
[Explicit]
public class CodingHelperTests
{

    [Test]
    public void Test()
    {
        // Arrange 
        var types = TypeHelper.GetTypesDerivedFromCurrentAssembly(typeof(ParagraphBase));

        var sb = new StringBuilder();

        // Act  
        foreach (var type in types)
        {
            sb.AppendLine(type.Name);
        }

        // Assert
        Debug.Print(sb.ToString());

    }


    /// <summary>
    /// Style for <see cref="Paragraph"/> instances
    /// </summary>
    [Test]
    public void CreateStyles_ParagraphBase_AllStylesCreatedAsString()
    {
        var baseType = typeof(ParagraphBase);

        PrintCodeForStyles(baseType);
    }

    [Test]
    public void CreateStyles_ImageBase_AllStylesCreatedAsString()
    {
        var baseType = typeof(ImageBase);

        PrintCodeForStyles(baseType);
    }

    private static void PrintCodeForStyles(Type baseType)
    {
        // Arrange 
        var types = TypeHelper.GetTypesDerivedFromCurrentAssembly(baseType).Where(x=> !x.IsAbstract);

        var sb = new StringBuilder();

        // Act  
        foreach (var type in types)
        {
            sb.AppendLine("/// <summary>");
            sb.AppendLine($"/// Style for <see cref=\"{type.Name}\"/> instances");
            sb.AppendLine("/// </summary>");
            sb.AppendLine($"public class {type.Name}Style : {baseType.Name.Replace("Base", "StyleBase")}");
            sb.AppendLine("{");
            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// Default ctor");
            sb.AppendLine("/// </summary>");
            sb.AppendLine($"public {type.Name}Style()");
            sb.AppendLine("{");
            sb.AppendLine($"TagToUse =\"{type.Name}Style\";");
            sb.AppendLine("Name = TagToUse;");
            sb.AppendLine("}");
            sb.AppendLine("}");
            sb.AppendLine("");
        }

        // Assert
        Debug.Print(sb.ToString());
    }
}