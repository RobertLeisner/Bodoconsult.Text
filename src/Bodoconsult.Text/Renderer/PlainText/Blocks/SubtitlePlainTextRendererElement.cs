// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Subtitle"/> instances
/// </summary>
public class SubtitlePlainTextRendererElement : ITextRendererElement
{
    private readonly Subtitle _subtitle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public SubtitlePlainTextRendererElement(Subtitle subtitle)
    {
        _subtitle = subtitle;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, renderer.Content, _subtitle.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}