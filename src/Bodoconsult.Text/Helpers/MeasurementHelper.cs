// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;

namespace Bodoconsult.Text.Helpers;

/// <summary>
/// Helepr class for measurement conversions using diverse units like cm, Twips, inch etc.
/// </summary>
public static class MeasurementHelper
{
    /// <summary>
    /// Size of a typograhic Point pt in cm
    /// </summary>
    public const double CentimeterPerPoint = 0.0352775;

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

    /// <summary>
    /// Convert cm into Twips
    /// </summary>
    /// <param name="i">cm</param>
    /// <returns>Twips</returns>
    public static int GetTwipsFromCm(double i)
    {
        var result = i / 2.54f * 1440;
        return (int)Math.Ceiling(result);
    }

    /// <summary>
    /// Convert mm into Twips
    /// </summary>
    /// <param name="i">mm</param>
    /// <returns>Twips</returns>
    public static int GetTwipsFromMm(double i)
    {
        var result = i / 25.4f * 1440;
        return (int)Math.Ceiling(result);
    }

    /// <summary>
    /// Get Twips from typographic point pt
    /// </summary>
    /// <param name="pt">pt</param>
    /// <returns>Twips</returns>
    public static int GetTwipsFromPt(double pt)
    {
        return GetTwipsFromCm(pt * CentimeterPerPoint);
    }

    /// <summary>
    /// Get Twips from pixels px
    /// </summary>
    /// <param name="px">px</param>
    /// <returns>Twips</returns>
    public static int GetTwipsFromPx(int px)
    {
        return px * 15;
    }

    /// <summary>
    /// Get typographic points from cm
    /// </summary>
    /// <param name="cm">cm</param>
    /// <returns>typographic points pt</returns>
    public static double GetPtFromCm(double cm)
    {
        return Math.Round(cm / CentimeterPerPoint, 1);
    }

    /// <summary>
    /// Get typographic points from mm
    /// </summary>
    /// <param name="mm">mm</param>
    /// <returns>typographic points pt</returns>
    public static double GetPtFromMm(double mm)
    {
        return Math.Round(mm / 10.0 / CentimeterPerPoint, 2);
    }

    /// <summary>
    /// Get pixel px from Twips
    /// </summary>
    /// <param name="twips">Twips</param>
    /// <returns>px</returns>
    public static int GetPxFromTwips(int twips)
    {
        return twips / 15;
    }
}