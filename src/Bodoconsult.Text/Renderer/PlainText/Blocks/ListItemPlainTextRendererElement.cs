// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="ListItem"/> instances
/// </summary>
public class ListItemPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{


    /// <summary>
    /// Default ctor
    /// </summary>
    public ListItemPlainTextRendererElement(ListItem listItem)
    {
        _paragraph = listItem;
    }
}