// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Text;
using Bodoconsult.Text.Documents;
using MigraDoc.DocumentObjectModel;

namespace Bodoconsult.Text.Pdf.Renderer.Inlines;

/// <summary>
/// Render a <see cref="Bold"/> element
/// </summary>
public class BoldPdfTextRendererElement : InlinePdfTextRendererElementBase
{
    private readonly Bold _span;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="span">Paragraph</param>
    public BoldPdfTextRendererElement(Bold span)
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
        paragraph.AddFormattedText(_span.Content, TextFormat.Bold);
    }

    /// <summary>
    /// Render the inline to a string
    /// </summary>
    /// <param name="sb">String</param>
    /// <exception cref="NotSupportedException"></exception>
    public override void RenderToString(StringBuilder sb)
    {
        sb.Append(_span.Content);
    }
}