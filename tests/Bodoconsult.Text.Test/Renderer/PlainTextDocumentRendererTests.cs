// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Diagnostics;
using Bodoconsult.Text.Renderer.PlainText;
using Bodoconsult.Text.Test.Helpers;
using NUnit.Framework;

namespace Bodoconsult.Text.Test.Renderer;

[TestFixture]
public class PlainTextDocumentRendererTests
{

    [Test]
    public void Ctor_ValidDocument_PropsSetCorrectly()
    {
        // Arrange 
        var document = TestDataHelper.CreateDocument();
        var factory = new PlainTextRendererElementFactory();

        // Act  
        var renderer = new PlainTextDocumentRenderer(document, factory);

        // Assert
        Assert.That(renderer.Document, Is.Not.Null);
        Assert.That(renderer.Styleset, Is.Not.Null);
        Assert.That(renderer.PageStyleBase, Is.Not.Null);
        Assert.That(renderer.Content, Is.Not.Null);
        Assert.That(renderer.Content.Length, Is.EqualTo(0));
    }

    [Test]
    public void RenderIt_ValidDocument_PropsSetCorrectly()
    {
        // Arrange 
        var document = TestDataHelper.CreateDocument();
        var factory = new PlainTextRendererElementFactory();

        var renderer = new PlainTextDocumentRenderer(document, factory);

        // Act  
        renderer.RenderIt();

        // Assert
        Assert.That(renderer.Content.Length, Is.Not.EqualTo(0));

        Debug.Print(renderer.Content.ToString());
    }

}