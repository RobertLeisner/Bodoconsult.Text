// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Extensions;

/// <summary>
/// Extenion methods for <see cref="Color"/>
/// </summary>
public static class ColorExtensions
{
    /// <summary>
    /// Get an HTML string like #000000 for a color
    /// </summary>
    /// <param name="color">Current color</param>
    /// <returns>HTML color string like #000000</returns>
    public static string ToHtml(this Color color)
    {
        return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
    }
}