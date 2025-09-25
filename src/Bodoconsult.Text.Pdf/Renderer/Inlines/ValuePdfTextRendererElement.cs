// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using System;
using System.Text;

namespace Bodoconsult.Text.Pdf.Renderer.Inlines;

/// <summary>
/// Render a <see cref="Value"/> element
/// </summary>
public class ValuePdfTextRendererElement : InlinePdfTextRendererElementBase
{
    private readonly Value _value;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="value">Paragraph</param>
    public ValuePdfTextRendererElement(Value value)
    {
        _value = value;
    }

    /// <summary>
    /// Render the inline element to string
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    /// <param name="paragraph">Paragraph to render the inline into</param>
    public override void RenderIt(PdfTextDocumentRenderer renderer, MigraDoc.DocumentObjectModel.Paragraph paragraph)
    {
        paragraph.AddText(_value.Content);
    }

    /// <summary>
    /// Render the inline to a string
    /// </summary>
    /// <param name="sb">String</param>
    /// <exception cref="NotSupportedException"></exception>
    public override void RenderToString(StringBuilder sb)
    {
        sb.Append(_value.Content);
    }
}