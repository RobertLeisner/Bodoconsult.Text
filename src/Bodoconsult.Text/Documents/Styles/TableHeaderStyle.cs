// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Table"/> instances
/// </summary>
public class TableHeaderStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public TableHeaderStyle()
    {
        TagToUse = "TableHeaderStyle";
        Name = TagToUse;
        Bold = true;
        BorderBrush = new SolidColorBrush(Colors.Black);
        BorderThickness = new Thickness(1.0, 1.0, 1.0, 1.0);
        Paddings = new Thickness(Document.DefaultPaddingWidth);
    }
}