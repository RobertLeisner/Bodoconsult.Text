// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="ListItem"/> instances
/// </summary>
public class ListItemPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly ListItem _listItem;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListItemPdfTextRendererElement(ListItem listItem) : base(listItem)
    {
        _listItem = listItem;
        ClassName = listItem.StyleName;
    }
}