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

    private readonly string _leftMargin;
    private readonly string _content;
    private readonly ParagraphStyleBase _paragraphStyle;
    private PageStyleBase _pageStyle;
    private readonly ReadOnlyMemory<char> _bytes;
    private int _maxLength;

    private string _leftBorderChar;
    private string _rightBorderChar;

    private string _leftPadding;
    private string _rightPadding;
    private string _topBottomLine;

    /// <summary>
    /// Char used for left and right borders
    /// </summary>
    public string LeftRightBorderChar { get; set; } = "|";

    /// <summary>
    /// Char used for top and bottom borders
    /// </summary>
    public string TopBottomBorderChar { get; set; } = "-";

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

        _paragraphStyle = paragraphStyle;
        _pageStyle = pageStyle;

        WidthsInChars = (int)((pageStyle.TypeAreaWidth - paragraphStyle.Margins.Left - paragraphStyle.Margins.Right) / CharWidth);


        var marginLeft = (uint)(paragraphStyle.Margins.Left / CharWidth);

        _leftMargin = marginLeft == 0 ? string.Empty : " ".Repeat(marginLeft);


        // Check if left border is needed
        if (paragraphStyle.BorderThickness.Left > 0)
        {
            _leftBorderChar = LeftRightBorderChar;
            WidthsInChars -= 1;
        }
        else
        {
            _leftBorderChar = string.Empty;
        }

        // Check if right border is needed

        if (paragraphStyle.BorderThickness.Left > 0)
        {
            _rightBorderChar = LeftRightBorderChar;
            WidthsInChars -= 1;
        }
        else
        {
            _rightBorderChar = string.Empty;
        }

        // Check if left padding is needed
        if (paragraphStyle.Paddings.Left > 0)
        {
            _leftPadding = " ";
            WidthsInChars -= 1;
        }
        else
        {
            _leftPadding = string.Empty;
        }

        // Check if right padding is needed
        if (paragraphStyle.Paddings.Right > 0)
        {
            _rightPadding = " ";
            WidthsInChars -= 1;
        }
        else
        {
            _rightPadding = string.Empty;
        }

        // Check if top border and/or bottom border is needed
        if (paragraphStyle.BorderThickness.Top > 0 || paragraphStyle.BorderThickness.Bottom > 0)
        {
            _topBottomLine = TopBottomBorderChar.Repeat(WidthsInChars +
                                                                    2 * LeftRightBorderChar.Length +
                                                                    _leftPadding.Length +
                                                                    _rightPadding.Length);
        }
        else
        {
            _topBottomLine = string.Empty;
        }


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

        if (_paragraphStyle.BorderThickness.Top > 0)
        {
            result.Add(_leftMargin + _topBottomLine);
        }

        foreach (var line in Lines)
        {
            FormatLine(result, line);
        }

        if (_paragraphStyle.BorderThickness.Bottom > 0)
        {
            result.Add(_leftMargin + _topBottomLine);
        }

        Lines.Clear();
        Lines.AddRange(result);
    }

    private void FormatLine(List<string> result, string line)
    {

        var missinglength = WidthsInChars - line.Length;

        if (_paragraphStyle.TextAlignment == TextAlignment.Left)
        {
            result.Add($"{_leftMargin}{_leftBorderChar}{_leftPadding}{line}{" ".Repeat(missinglength)}{_rightPadding}{_rightBorderChar}");
            return;
        }

        if (_paragraphStyle.TextAlignment == TextAlignment.Right)
        {
            result.Add($"{_leftMargin}{_leftBorderChar}{_leftPadding}{line.PadLeft(WidthsInChars)}{_rightPadding}{_rightBorderChar}");
            return;
        }


        if (_paragraphStyle.TextAlignment == TextAlignment.Center)
        {
            var length = (uint)((WidthsInChars - line.Length) / 2.0);
            if (length > 0)
            {
                result.Add($"{_leftMargin}{_leftBorderChar}{_leftPadding}{" ".Repeat(length)}{line}{" ".Repeat(length)}{_rightPadding}{_rightBorderChar}");
            }
            else
            {
                result.Add($"{_leftMargin}{_leftBorderChar}{_leftPadding}{line}{_rightPadding}{_rightBorderChar}");
            }

            return;
        }

        // ToDo: justify
        if (_paragraphStyle.TextAlignment == TextAlignment.Justify)
        {
            result.Add($"{_leftMargin}{line}");
            return;
        }
    }

    private void GetLines()
    {
        // Only one line
        if (_content.Length < WidthsInChars)
        {
            Lines.Add(_content);
            return;
        }

        // More than one line
        var pos = WidthsInChars - 1;
        var altPos = 0;
        var length = _bytes.Length - 1;


        while (true)
        {

            // Check if current char is a blank (0x20). If not go back until a blank is found
            while (pos < length && _bytes.Span[pos] != 0x20 && pos >= 0)
            {
                pos--;
            }

            if (pos < 0 || pos >= length)
            {
                return;
            }

            // Take the part of the content from altPos up to pos as new line
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