// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="SectionSubtitle"/> instances
/// </summary>
public class SectionSubtitleStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionSubtitleStyle()
    {
        TagToUse = "SectionSubtitleStyle";
        Name = TagToUse;
        FontSize = Document.DefaultFontSize + 2;
        Margins.Top = Document.DefaultFontSize * 2;
        TextAlignment = TextAlignment.Center;
    }
}