// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;

namespace Bodoconsult.Text.Helpers;

/// <summary>
/// Helepr class for measurement conversions using diverse units like cm, Twips, inch etc.
/// </summary>
public static class MeasurementHelper
{
    /// <summary>
    /// Convert cm into Twips
    /// </summary>
    /// <param name="i">cm</param>
    /// <returns>Twips</returns>
    public static int GetTwipsFromCm(float i)
    {
        var result = i / 2.54f * 1440;
        return (int)Math.Ceiling(result);
    }

    /// <summary>
    /// Convert mm into Twips
    /// </summary>
    /// <param name="i">mm</param>
    /// <returns>Twips</returns>
    public static int GetTwipsFromMm(float i)
    {
        var result = i / 25.4f * 1440;
        return (int)Math.Ceiling(result);
    }
}