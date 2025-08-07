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
using Bodoconsult.Text.Extensions;

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

    /// <summary>
    /// Style for <see cref="Paragraph"/> instances
    /// </summary>
    [Test]
    public void CreateRendererElements_ImageBase_AllRendererElementsCreatedAsString()
    {
        var baseType = typeof(ImageBase);

        PrintCodeForRendererElements(baseType);
    }

    /// <summary>
    /// Style for <see cref="Paragraph"/> instances
    /// </summary>
    [Test]
    public void CreateRendererElements_ParagraphBase_AllRendererElementsCreatedAsString()
    {
        var baseType = typeof(ParagraphBase);

        PrintCodeForRendererElements(baseType);
    }

    private static void PrintCodeForRendererElements(Type baseType)
    {
        // Arrange 
        var types = TypeHelper.GetTypesDerivedFromCurrentAssembly(baseType)
            .Where(x => !x.IsAbstract );

        //&& x == typeof(Paragraph)

        var sb = new StringBuilder();

        // Act  
        foreach (var type in types)
        {
            sb.AppendLine("/// <summary>");
            sb.AppendLine($"/// Text rendering element for <see cref=\"{type.Name}\"/> instances");
            sb.AppendLine("/// </summary>");
            sb.AppendLine($"public class {type.Name}PlainTextRendererElement : ITextRendererElement");
            sb.AppendLine("{");
            sb.AppendLine($"private readonly {type.Name} _{type.Name};");
            sb.AppendLine("");



            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// Default ctor");
            sb.AppendLine("/// </summary>");
            sb.AppendLine($"public {type.Name}PlainTextRendererElement({type.Name} {type.Name})");
            sb.AppendLine("{");
            sb.AppendLine($"_{type.Name} = {type.Name};");
            sb.AppendLine("}");
            sb.AppendLine("");

            sb.AppendLine("/// <summary>");
            sb.AppendLine("/// Render the elememt");
            sb.AppendLine("/// </summary>");
            sb.AppendLine(" public void RenderIt(ITextDocumentRender renderer)");
            sb.AppendLine("{");
            sb.AppendLine($"DocumentRendererHelper.RenderInlineChilds(renderer, _{type.Name}.ChildInlines, string.Empty, true);");
            sb.AppendLine("renderer.Content.Append($\"{Environment.NewLine}\");");
            sb.AppendLine("}");
            sb.AppendLine("}");
            sb.AppendLine("");
        }

        // Assert
        Debug.Print(sb.ToString());
    }

    /// <summary>
    /// Style for <see cref="Paragraph"/> instances
    /// </summary>
    [Test]
    public void CreateDefaultStyleset_ImageBase_AllStylesCreatedAsString()
    {
        var baseType = typeof(ImageBase);

        PrintCodeForDefaultStyleset(baseType);
    }

    /// <summary>
    /// Style for <see cref="Paragraph"/> instances
    /// </summary>
    [Test]
    public void CreateDefaultStyleset_ParagraphBase_AllStylesCreatedAsString()
    {
        var baseType = typeof(ParagraphBase);

        PrintCodeForDefaultStyleset(baseType);
    }

    private static void PrintCodeForDefaultStyleset(Type baseType)
    {
        // Arrange 
        var types = TypeHelper.GetTypesDerivedFromCurrentAssembly(baseType)
            .Where(x => !x.IsAbstract);

        //&& x == typeof(Paragraph)

        var sb = new StringBuilder();

        // Act  
        foreach (var type in types)
        {
            sb.AppendLine("");
            sb.AppendLine($"// Add style <see cref=\"{type.Name}Style\"/> for <see cref=\"{type.Name}\"/> instances ");
            sb.AppendLine($"var {type.Name.ToLowerInvariant()}Style = new {type.Name}Style();");
            sb.AppendLine($"styleSet.AddBlock({type.Name.ToLowerInvariant()}Style );");
        }

        // Assert
        Debug.Print(sb.ToString());
    }


    /// <summary>
    /// Style for <see cref="Paragraph"/> instances
    /// </summary>
    [Test]
    public void CreateRendererElementFactory_ImageBase_AllElementsCreatedAsString()
    {
        var baseType = typeof(ImageBase);

        PrintCodeForDefaultStyleset(baseType);
    }

    /// <summary>
    /// Style for <see cref="Paragraph"/> instances
    /// </summary>
    [Test]
    public void CreateRendererElementFactory_ParagraphBase_AllElementsCreatedAsString()
    {
        var baseType = typeof(ParagraphBase);

        PrintCodeForRendererElementFactory(baseType);
    }

    private static void PrintCodeForRendererElementFactory(Type baseType)
    {
        // Arrange 
        var types = TypeHelper.GetTypesDerivedFromCurrentAssembly(baseType)
            .Where(x => !x.IsAbstract);

        //&& x == typeof(Paragraph)

        var sb = new StringBuilder();

        // Act  
        foreach (var type in types)
        {
            sb.AppendLine("");
            sb.AppendLine($"if (textElement is {type.Name} {type.Name.FirstCharToLowerCase()})");
            sb.AppendLine("{");
            sb.AppendLine($"return new {type.Name}PlainTextRendererElement({type.Name.FirstCharToLowerCase()} );");
            sb.AppendLine("}");

        }
        // Assert
        Debug.Print(sb.ToString());
    }

}


