// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Heading1"/> instances
/// </summary>
public class Heading1Style : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Heading1Style()
    {
        TagToUse = "Heading1Style";
        Name = TagToUse;
        BorderBrush = new SolidColorBrush(Colors.Black);
        BorderBrush = new SolidColorBrush(Document.DefaultColor);
        BorderThickness.Bottom = Document.DefaultBorderWidth;
        BorderThickness.Top = Document.DefaultBorderWidth;
        Margins.Top = 4 * Document.DefaultFontSize;
        Margins.Bottom = 1 * Document.DefaultFontSize;
    }
}