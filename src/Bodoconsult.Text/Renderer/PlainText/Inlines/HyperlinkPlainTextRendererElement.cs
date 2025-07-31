// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Render a <see cref="Hyperlink"/> element
/// </summary>
public class HyperlinkPlainTextRendererElement : ITextRendererElement
{
    private readonly Hyperlink _span;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="span">Hyperlink</param>
    public HyperlinkPlainTextRendererElement(Hyperlink span)
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
                renderer.Content.Append($" => [{renderer.CheckContent(_span.Content)}]({_span.Uri}){Environment.NewLine}");
            }
            else
            {
                renderer.Content.Append($"[{renderer.CheckContent(_span.Content)}]({_span.Uri})");
            }
        }
        else
        {
            DocumentRendererHelper.RenderInlineChilds(renderer, _span.ChildInlines, "*");
        }
    }
}