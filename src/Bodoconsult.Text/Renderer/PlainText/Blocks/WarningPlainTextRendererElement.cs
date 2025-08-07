// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Warning"/> instances
/// </summary>
public class WarningPlainTextRendererElement : ITextRendererElement
{
    private readonly Warning _warning;

    /// <summary>
    /// Default ctor
    /// </summary>
    public WarningPlainTextRendererElement(Warning warning)
    {
        _warning = warning;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, renderer.Content, _warning.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}