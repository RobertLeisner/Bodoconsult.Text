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
    public string FontName { get; set; } = "Calibri";

    /// <summary>
    /// Font size in pt
    /// </summary>
    public int FontSize { get; set; } = 12;

    /// <summary>
    /// Bold
    /// </summary>
    public bool Bold { get; set; }

    /// <summary>
    /// Italic
    /// </summary>
    public bool Italic { get; set; }

    /// <summary>
    /// Left margin in pt
    /// </summary>
    public double MarginLeft { get; set; }

    /// <summary>
    /// Left margin in pt
    /// </summary>
    public double MarginTop { get; set; }

    /// <summary>
    /// Left margin in pt
    /// </summary>
    public double MarginRight { get; set; }

    /// <summary>
    /// Left margin in pt
    /// </summary>
    public double MarginBottom { get; set; }

    /// <summary>
    /// The alignment of the text
    /// </summary>
    public TextAlignment TextAlignment { get; set; } = TextAlignment.Left;

}