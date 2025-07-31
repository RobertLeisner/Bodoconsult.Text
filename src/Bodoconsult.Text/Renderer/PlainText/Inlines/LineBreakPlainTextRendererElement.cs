// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Render a <see cref="LineBreak"/> element
/// </summary>
public class LineBreakPlainTextRendererElement : ITextRendererElement
{
    private readonly LineBreak _span;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="span">Paragraph</param>
    public LineBreakPlainTextRendererElement(LineBreak span)
    {
        _span = span;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        renderer.Content.Append($"{Environment.NewLine}");
    }
}