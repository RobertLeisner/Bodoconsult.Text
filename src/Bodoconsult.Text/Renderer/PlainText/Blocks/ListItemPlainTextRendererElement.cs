// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

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
        Paragraph = listItem;
    }
}