// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Table"/> legend instances
/// </summary>
public class TableLegendStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public TableLegendStyle()
    {
        TagToUse = "TableLegendStyle";
        Name = TagToUse;
        Margins = new Thickness(0, Document.DefaultFontSize * 0.25, 0, Document.DefaultFontSize);
        TextAlignment = TextAlignment.Center;
        Italic = true;
    }
}