// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Extensions;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Paragraph formatter for plain text rendering
/// </summary>
public class PlainTextParagraphFormatter
{

    private readonly string _leftIndent;
    private readonly string _content;
    private readonly ParagraphStyleBase _paragraph;
    private PageStyleBase _pageStyle;
    private readonly ReadOnlyMemory<char> _bytes;
    private int _maxLength;

    /// <summary>
    /// Lines produced from content
    /// </summary>
    public List<string> Lines { get; } = new();

    /// <summary>
    /// Page with in number of chars. Public only for tests
    /// </summary>
    public int WidthsInChars { get; }

    /// <summary>
    /// Char width in cm
    /// </summary>
    private const double CharWidth = 0.25;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="content">Content to format</param>
    /// <param name="paragraphStyle">Paragraph style</param>
    /// <param name="pageStyle">Document or section page style</param>
    public PlainTextParagraphFormatter(string content, ParagraphStyleBase paragraphStyle, PageStyleBase pageStyle)
    {
        _content = content;

        _bytes = _content.AsMemory();

        _paragraph = paragraphStyle;
        _pageStyle = pageStyle;

        WidthsInChars = (int)((pageStyle.TypeAreaWidth - paragraphStyle.Margins.Left - paragraphStyle.Margins.Right) / CharWidth);


        var marginLeft = (uint)(paragraphStyle.Margins.Left / CharWidth);

        _leftIndent = marginLeft == 0 ? string.Empty : " ".Repeat(marginLeft);

    }

    /// <summary>
    /// Format the text
    /// </summary>
    public void FormatText()
    {
        GetLines();

        FormatLines();
    }

    private void FormatLines()
    {
        var result = new List<string>();

        foreach (var line in Lines)
        {

            if (_paragraph.TextAlignment == TextAlignment.Left)
            {
                result.Add($"{_leftIndent}{line}");
                continue;
            }

            if (_paragraph.TextAlignment == TextAlignment.Right)
            {
                result.Add($"{_leftIndent}{line.PadLeft(_maxLength)}");
                continue;
            }

            if (_paragraph.TextAlignment == TextAlignment.Center)
            {
                var length = (uint)((_maxLength - line.Length) / 2.0);
                result.Add(length > 0 ? $"{_leftIndent}{" ".Repeat(length)}{line}" : $"{_leftIndent}{line}");

                continue;
            }

            // ToDo: justify
            if (_paragraph.TextAlignment == TextAlignment.Justify)
            {
                result.Add($"{_leftIndent}{line}");
                continue;
            }
        }

        Lines.Clear();
        Lines.AddRange(result);

    }

    private void GetLines()
    {
        // Only one line
        if (_content.Length < WidthsInChars)
        {
            Lines.Add(_content);
            return;
        }

        var pos = WidthsInChars - 1;
        var altPos = 0;
        var length = _bytes.Length - 1;


        while (true)
        {
            while (pos < length && _bytes.Span[pos] != 0x20 && pos >= 0)
            {
                pos--;
            }

            if (pos < 0 || pos >= length)
            {
                return;
            }

            var value = _bytes.Slice(altPos, pos - altPos).Span.ToString();

            if (_maxLength < value.Length)
            {
                _maxLength = value.Length;
            }

            Debug.Print($"{altPos} {pos}: {value.Length}: {value}");

            Lines.Add(value);

            altPos = pos + 1;
            pos += WidthsInChars - 1;
        }
    }


    /// <summary>
    /// Get the formatted text as result
    /// </summary>
    /// <returns><see cref="StringBuilder"/> instance containing the formatted text</returns>
    public StringBuilder GetFormattedText()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var line in Lines)
        {
            sb.AppendLine(line);
        }

        return sb;
    }




}