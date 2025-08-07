// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc4"/> instances
/// </summary>
public class Toc4PlainTextRendererElement : ITextRendererElement
{
    private readonly Toc4 _toc4;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc4PlainTextRendererElement(Toc4 toc4)
    {
        _toc4 = toc4;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, renderer.Content, _toc4.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}