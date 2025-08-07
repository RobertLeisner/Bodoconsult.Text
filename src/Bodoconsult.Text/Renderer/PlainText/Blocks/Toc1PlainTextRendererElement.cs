// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc1"/> instances
/// </summary>
public class Toc1PlainTextRendererElement : ITextRendererElement
{
    private readonly Toc1 _toc1;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc1PlainTextRendererElement(Toc1 toc1)
    {
        _toc1 = toc1;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, renderer.Content, _toc1.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}