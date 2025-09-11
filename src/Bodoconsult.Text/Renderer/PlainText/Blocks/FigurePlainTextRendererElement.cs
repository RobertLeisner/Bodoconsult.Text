// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Text;

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
    /// Render the element
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        var sb = new StringBuilder();
        sb.Append(_figure.CurrentPrefix);
        DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _figure.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"![{sb}]({_figure.Uri} \"{sb}\"){Environment.NewLine}{Environment.NewLine}");
    }
}