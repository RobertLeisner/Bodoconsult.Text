// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Diagnostics;
using System.Text;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Paragraph"/> instances
/// </summary>
public class ParagraphPlainTextRendererElement: ITextRendererElement
{
    private readonly Paragraph _paragraph;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="paragraph">Paragraph</param>
    public ParagraphPlainTextRendererElement(Paragraph paragraph)
    {
        _paragraph = paragraph;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();
        DocumentRendererHelper.RenderInlineChilds(renderer, sb, _paragraph.ChildInlines, string.Empty, true);

        //Debug.Print(sb.ToString());

        // Now let the formatter work
        var style = (ParagraphStyleBase)renderer.Styleset.FindStyle($"{_paragraph.GetType().Name}Style");
        var formatter = new PlainTextParagraphFormatter(sb.ToString(), style, renderer.PageStyleBase);
        formatter.FormatText();

        // Now add the formatted text to the rendered content
        renderer.Content.Append($"{formatter.GetFormattedText()}");
    }
}