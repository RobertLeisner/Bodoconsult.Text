// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Diagnostics;
using System.Text;
using Bodoconsult.Text.Documents;
using NUnit.Framework;

namespace Bodoconsult.Text.Test.Documents;

[TestFixture]
internal class ParagraphStyleTests
{


    [Test]
    public void Ctor_DefaultCtor_PropsSetCorrectly()
    {
        // Arrange 

        // Act  
        var style = new ParagraphStyle();

        // Assert
        Assert.That(style.ChildBlocks.Count, Is.EqualTo(0));
        Assert.That(style.ChildInlines.Count, Is.EqualTo(0));
        Assert.That(style.FontSize, Is.Not.EqualTo(0));
    }

    [Test]
    public void ToLdmlString_DefaultCtor_LdmlCreatedWellformed()
    {
        // Arrange 
        var style = new ParagraphStyle();

        var sb = new StringBuilder();

        // Act  
        style.ToLdmlString(sb, string.Empty);

        // Assert
        Assert.That(sb.Length, Is.Not.EqualTo(0));

        Debug.Print(sb.ToString());
    }
}