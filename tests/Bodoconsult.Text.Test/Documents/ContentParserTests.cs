// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Collections.Generic;
using Bodoconsult.Text.Documents;
using NUnit.Framework;

namespace Bodoconsult.Text.Test.Documents;

[TestFixture]
internal class ContentParserTests
{
    private const string Section1 = "Blubb";
    private const string Section2 = "Blabb";
    private const string Section3 = "Blobb";

    [Test]
    public void Ctor_ValidSetup_PropsSetCorrectly()
    {
        // Arrange 
        var content = Section1;
        var block = new Paragraph();

        // Act  
        var cp = new ContentParser(content, block);

        // Assert
        Assert.That(block.ChildInlines.Count, Is.EqualTo(0));

    }

    [Test]
    public void Parse_SimpleString_Finds1Inline()
    {
        // Arrange 
        var content = Section1;
        var block = new Paragraph();

        var cp = new ContentParser(content, block);

        // Act  
        cp.Parse();

        // Assert
        Assert.That(block.ChildInlines.Count, Is.EqualTo(1));

    }

    [Test]
    public void Parse_StringWithGreater_Finds1Inline()
    {
        // Arrange 
        var content = "Blu>bb";
        var block = new Paragraph();

        var cp = new ContentParser(content, block);

        // Act  
        cp.Parse();

        // Assert
        Assert.That(block.ChildInlines.Count, Is.EqualTo(1));

    }

    [Test]
    public void Parse_StringWithLower_Finds1Inline()
    {
        // Arrange 
        var content = "Blu<bb";
        var block = new Paragraph();

        var cp = new ContentParser(content, block);

        // Act  
        cp.Parse();

        // Assert
        Assert.That(block.ChildInlines.Count, Is.EqualTo(1));

    }

    [Test]
    public void Parse_StringSpanBold_Finds2Inline()
    {
        // Arrange 
        var content = $"{Section1}<b>{Section2}</b>";
        var block = new Paragraph();

        var cp = new ContentParser(content, block);

        // Act  
        cp.Parse();

        // Assert
        Assert.That(block.ChildInlines.Count, Is.EqualTo(2));

    }

    [Test]
    public void Parse_StringSpanBoldOpen_Finds2Inline()
    {
        // Arrange 
        var content = $"{Section1}<b>{Section2}";
        var block = new Paragraph();

        var cp = new ContentParser(content, block);

        // Act  
        cp.Parse();

        // Assert
        Assert.That(block.ChildInlines.Count, Is.EqualTo(2));

    }

    [Test]
    public void Parse_StringSpanBoldSpan_Finds3Inline()
    {
        // Arrange 
        var content = $"{Section1}<b>{Section2}</b>{Section3}";
        var block = new Paragraph();

        var cp = new ContentParser(content, block);

        // Act  
        cp.Parse();

        // Assert
        Assert.That(block.ChildInlines.Count, Is.EqualTo(3));

    }

}