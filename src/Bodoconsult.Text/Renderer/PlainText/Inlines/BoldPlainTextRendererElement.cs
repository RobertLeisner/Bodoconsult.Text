// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Render a <see cref="Bold"/> element
/// </summary>
public class BoldPlainTextRendererElement : ITextRendererElement
{
    private readonly Bold _span;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="span">Paragraph</param>
    public BoldPlainTextRendererElement(Bold span)
    {
        _span = span;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        if (_span.ChildInlines.Count == 0)
        {
            if (_span.Parent is Block)
            {
                renderer.Content.Append($"*{renderer.CheckContent(_span.Content)}*{Environment.NewLine}");
            }
            else
            {
                renderer.Content.Append($"*{renderer.CheckContent(_span.Content)}*");
            }
        }
        else
        {
            DocumentRendererHelper.RenderInlineChilds(renderer, _span.ChildInlines, "*");
        }
    }
}