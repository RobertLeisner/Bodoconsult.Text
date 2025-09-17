// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Citation"/> instances
/// </summary>
public class CitationStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public CitationStyle()
    {
        TagToUse = "CitationStyle";
        Name = TagToUse;
        TextAlignment = TextAlignment.Center;
        Margins.Top = 3 * Document.DefaultPaddingWidth;
        Margins.Bottom = 0;
        Margins.Left = Document.DefaultMarginLeft;
        Margins.Right = Document.DefaultMarginRight;
        Italic = true;
        KeepWithNextParagraph = true;
        KeepTogether = true;
    }
}