// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Error"/> instances
/// </summary>
public class ErrorStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public ErrorStyle()
    {
        TagToUse = "ErrorStyle";
        Name = TagToUse;
        BorderBrush = new SolidColorBrush(Colors.Red);
        BorderThickness.Bottom = Document.DefaultBorderWidth;
        BorderThickness.Left = Document.DefaultBorderWidth;
        BorderThickness.Right = Document.DefaultBorderWidth;
        BorderThickness.Top = Document.DefaultBorderWidth;
        Paddings.Left = Document.DefaultPaddingWidth;
        Paddings.Right = Document.DefaultPaddingWidth;
        Paddings.Top = Document.DefaultPaddingWidth;
        Paddings.Bottom = Document.DefaultPaddingWidth;
        Margins.Top = 3 * Document.DefaultPaddingWidth;
        Margins.Bottom = 3 * Document.DefaultPaddingWidth;
        KeepTogether = true;
    }
}