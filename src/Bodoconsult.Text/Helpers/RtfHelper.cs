// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using System.Text;

namespace Bodoconsult.Text.Helpers;

/// <summary>
/// Rtf helper class
/// </summary>
public static class RtfHelper
{
    /// <summary>
    /// Get the RTF format settings for a paragraph setting
    /// </summary>
    /// <param name="style">Style</param>
    /// <returns>RTF format settings</returns>
    public static StringBuilder GetFormatSettings(ParagraphStyleBase style)
    {
        var sb = new StringBuilder();

        // Font size
        sb.Append($"\\fs{style.FontSize * 2}");

        // Horizontal alignment
        switch (style.TextAlignment)
        {
            case TextAlignment.Left:
                sb.Append("\\ql") ;
                break;
            case TextAlignment.Right:
                sb.Append("\\qr");
                break;
            case TextAlignment.Center:
                sb.Append("\\qc");
                break;
            case TextAlignment.Justify:
                sb.Append("\\qj");
                break;
        }

        // Italic
        if (style.Italic)
        {
            sb.Append("\\i");
        }

        // Bold
        if (style.Bold)
        {
            sb.Append("\\b");
        }

        return sb;
    }
}