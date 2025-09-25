// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using MigraDoc.DocumentObjectModel;
using System;
using System.Text;

namespace Bodoconsult.Text.Pdf.Renderer.Inlines;

/// <summary>
/// Render a <see cref="Documents.Hyperlink"/> element
/// </summary>
public class HyperlinkPdfTextRendererElement : InlinePdfTextRendererElementBase
{
    private readonly Documents.Hyperlink _span;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="span">Hyperlink</param>
    public HyperlinkPdfTextRendererElement(Documents.Hyperlink span)
    {
        _span = span;
    }

    /// <summary>
    /// Render the inline element to string
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    /// <param name="paragraph">Paragraph to render the inline into</param>
    public override void RenderIt(PdfTextDocumentRenderer renderer, MigraDoc.DocumentObjectModel.Paragraph paragraph)
    {
        var h = paragraph.AddHyperlink(_span.Uri, HyperlinkType.Web);
        h.AddFormattedText(_span.Content);
    }

    /// <summary>
    /// Render the inline to a string
    /// </summary>
    /// <param name="sb">String</param>
    /// <exception cref="NotSupportedException"></exception>
    public override void RenderToString(StringBuilder sb)
    {
        sb.Append($"[{_span.Content}]({_span.Uri})");
    }
}