// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for TOF heading instances
/// </summary>
public class TofHeadingStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public TofHeadingStyle()
    {
        TagToUse = "TofHeadingStyle";
        Name = TagToUse;
        BorderBrush = new SolidColorBrush(Document.DefaultColor);
        BorderThickness.Bottom = 2 * Document.DefaultBorderWidth;
        BorderThickness.Top = 2 * Document.DefaultBorderWidth;
        Margins.Top = 4 * Document.DefaultFontSize;
        Margins.Bottom = 1 * Document.DefaultFontSize;
        Paddings.Top = Document.DefaultPaddingWidth;
        Paddings.Bottom = Document.DefaultPaddingWidth;
        Bold = true;
        FontSize = Document.DefaultFontSize + 2;
    }
}