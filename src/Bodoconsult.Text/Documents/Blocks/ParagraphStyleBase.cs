// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// A style for a normal left aligned paragraph
/// </summary>
public class ParagraphStyleBase : StyleBase
{
    /// <summary>
    /// Font name
    /// </summary>
    public string FontName { get; set; } = Document.DefaultFontName;

    /// <summary>
    /// Font size in pt
    /// </summary>
    public int FontSize { get; set; } = Document.DefaultFontSize;

    /// <summary>
    /// Bold
    /// </summary>
    public bool Bold { get; set; }

    /// <summary>
    /// Italic
    /// </summary>
    public bool Italic { get; set; }

    /// <summary>
    /// Text alignment legt, center, justify or right. Default: left
    /// </summary>
    public TextAlignment TextAlignment { get; set; } = TextAlignment.Left;

    /// <summary>
    /// Margins
    /// </summary>
    public Thickness Margins { get; set; } = new Thickness(0, Document.DefaultFontSize * 0.5, 0, 0);

}