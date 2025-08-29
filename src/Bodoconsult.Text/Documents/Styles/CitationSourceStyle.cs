// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Citation"/> source instances
/// </summary>
public class CitationSourceStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public CitationSourceStyle()
    {
        TagToUse = "CitationSourceStyle";
        Name = TagToUse;
        TextAlignment = TextAlignment.Center;
        Margins.Top = 0;
        Margins.Bottom = Document.DefaultPaddingWidth;
        Margins.Left = Document.DefaultMarginLeft;
        Margins.Right = Document.DefaultMarginRight;
        FontSize = Document.DefaultFontSize - 4;
    }
}