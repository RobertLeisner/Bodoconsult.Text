// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Diagnostics;
using System.Net.Mime;
using Bodoconsult.Text.Documents;
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

[TestFixture]
internal class PlainTextParagraphFormatterTests
{
    [Test]
    public void Ctor_DefaultSetup_PropsSetCorrectly()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle();
        var pageStyle = new DocumentStyle();

        const string content = "Blubb";

        // Act  
        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Assert
        Assert.That(f.WidthsInChars, Is.Not.EqualTo(0));

    }

    [Test]
    public void FormatText_ShortString_OneLineLeftAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle();
        var pageStyle = new DocumentStyle();

        const string content = "Blubb";

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.EqualTo(1));

        Debug.Print(f.GetFormattedText().ToString());

    }

    [Test]
    public void FormatText_LongString_MultipleLinesLeftAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle();
        var pageStyle = new DocumentStyle();

        const string content = TestDataHelper.MassText;

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.GreaterThan(1));

        Debug.Print(f.GetFormattedText().ToString());
    }

    [Test]
    public void FormatText_LongString_MultipleLinesRightAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle
        {
            TextAlignment = TextAlignment.Right
        };
        var pageStyle = new DocumentStyle();

        const string content = TestDataHelper.MassText;

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.GreaterThan(1));

        Debug.Print(f.GetFormattedText().ToString());
    }

    [Test]
    public void FormatText_LongString_MultipleLinesCenterAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle
        {
            TextAlignment = TextAlignment.Center
        };
        var pageStyle = new DocumentStyle();

        const string content = TestDataHelper.MassText;

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.GreaterThan(1));

        Debug.Print(f.GetFormattedText().ToString());
    }

    [Test]
    public void FormatText_LongStringMargin_MultipleLinesLeftAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle
        {
            Margins =
            {
                Left = 2,
                Right = 2
            }
        };

        var pageStyle = new DocumentStyle();

        const string content = TestDataHelper.MassText;

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.GreaterThan(1));

        Debug.Print(f.GetFormattedText().ToString());
    }

    [Test]
    public void FormatText_LongStringMargin_MultipleLinesRightAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle
        {
            TextAlignment = TextAlignment.Right,
            Margins =
            {
                Left = 2,
                Right = 2
            }
        };
        var pageStyle = new DocumentStyle();

        const string content = TestDataHelper.MassText;

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.GreaterThan(1));

        Debug.Print(f.GetFormattedText().ToString());
    }

    [Test]
    public void FormatText_LongStringMargin_MultipleLinesCenterAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle
        {
            TextAlignment = TextAlignment.Center,
            Margins =
            {
                Left = 2,
                Right = 2
            }
        };
        var pageStyle = new DocumentStyle();

        const string content = TestDataHelper.MassText;

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.GreaterThan(1));

        Debug.Print(f.GetFormattedText().ToString());
    }

    [Test]
    public void FormatText_LongStringMarginBorderPadding_MultipleLinesLeftAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle
        {
            Margins =
            {
                Left = 2,
                Right = 2
            },
            BorderBrush = new SolidColorBrush(Colors.Black),
            BorderThickness =
            {
                Left = 1,
                Top = 1,
                Right = 1,
                Bottom = 1
            },
            Paddings =
            {
                Left = 2,
                Right = 2
            },
        };

        var pageStyle = new DocumentStyle();

        const string content = TestDataHelper.MassText;

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.GreaterThan(1));

        Debug.Print(f.GetFormattedText().ToString());
    }

    [Test]
    public void FormatText_LongStringMarginBorderPadding_MultipleLinesRightAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle
        {
            Margins =
            {
                Left = 2,
                Right = 2
            },
            BorderBrush = new SolidColorBrush(Colors.Black),
            BorderThickness =
            {
                Left = 1,
                Top = 1,
                Right = 1,
                Bottom = 1
            },
            Paddings =
            {
                Left = 2,
                Right = 2
            },
            TextAlignment = TextAlignment.Right
        };

        var pageStyle = new DocumentStyle();

        const string content = TestDataHelper.MassText;

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.GreaterThan(1));

        Debug.Print(f.GetFormattedText().ToString());
    }

    [Test]
    public void FormatText_LongStringMarginBorderPadding_MultipleLinesCenterAlignment()
    {
        // Arrange 
        var paragraphStyle = new ParagraphStyle
        {
            Margins =
            {
                Left = 2,
                Right = 2
            },
            BorderBrush = new SolidColorBrush(Colors.Black),
            BorderThickness =
            {
                Left = 1,
                Top = 1,
                Right = 1,
                Bottom = 1
            },
            Paddings =
            {
                Left = 2,
                Right = 2
            },
            TextAlignment = TextAlignment.Center
        };

        var pageStyle = new DocumentStyle();

        const string content = TestDataHelper.MassText;

        var f = new PlainTextParagraphFormatter(content, paragraphStyle, pageStyle);

        // Act  
        f.FormatText();

        // Assert
        Assert.That(f.Lines.Count, Is.GreaterThan(1));

        Debug.Print(f.GetFormattedText().ToString());
    }
}