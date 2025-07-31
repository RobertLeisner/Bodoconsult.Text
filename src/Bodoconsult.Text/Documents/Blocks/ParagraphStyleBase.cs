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
    public string FontName { get; set; }

    /// <summary>
    /// Font size in pt
    /// </summary>
    public int FontSize { get; set; }

    /// <summary>
    /// Bold
    /// </summary>
    public bool Bold { get; set; }

    /// <summary>
    /// Italic
    /// </summary>
    public bool Italic { get; set; }



}