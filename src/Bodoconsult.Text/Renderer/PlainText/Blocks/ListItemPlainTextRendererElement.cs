// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="ListItem"/> instances
/// </summary>
public class ListItemPlainTextRendererElement : ITextRendererElement
{
    private readonly ListItem _listItem;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListItemPlainTextRendererElement(ListItem listItem)
    {
        _listItem = listItem;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, renderer.Content, _listItem.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}