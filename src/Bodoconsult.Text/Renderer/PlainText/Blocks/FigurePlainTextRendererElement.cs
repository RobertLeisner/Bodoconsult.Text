// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Figure"/> instances
/// </summary>
public class FigurePlainTextRendererElement : ITextRendererElement
{
    private readonly Figure _figure;

    /// <summary>
    /// Default ctor
    /// </summary>
    public FigurePlainTextRendererElement(Figure figure)
    {
        _figure = figure;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, renderer.Content, _figure.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}