// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;

namespace Bodoconsult.Text.Extensions;

/// <summary>
/// Extension methods for string
/// </summary>
public static class StringExtensions
{

    /// <summary>
    /// Repeat a string
    /// </summary>
    /// <param name="text">String to repeat</param>
    /// <param name="n">Number of repetitions</param>
    /// <returns></returns>
    public static string Repeat(this string text, uint n)
    {
        var textAsSpan = text.AsSpan();
        var span = new Span<char>(new char[textAsSpan.Length * (int)n]);
        for (var i = 0; i < n; i++)
        {
            textAsSpan.CopyTo(span.Slice((int)i * textAsSpan.Length, textAsSpan.Length));
        }

        return span.ToString();
    }

    /// <summary>
    /// Make first char of a string a lowercase char
    /// </summary>
    /// <param name="value">String</param>
    /// <returns>String with first char being lowercase</returns>
    public static string FirstCharToLowerCase(this string value)
    {
        if (!string.IsNullOrEmpty(value) && char.IsUpper(value[0]))
        {
            return value.Length == 1 ?
                char.ToLower(value[0]).ToString() :
                char.ToLower(value[0]) + value[1..];
        }

        return value;
    }
}