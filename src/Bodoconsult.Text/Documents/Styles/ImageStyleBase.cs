// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Base class for image related styles
/// </summary>
public abstract class ImageStyleBase : ParagraphStyleBase
{
    /// <summary>
    /// Image width in cm or double.NaN for image width equals content area width
    /// </summary>
    public double Width { get; set; } = double.NaN;

    /// <summary>
    /// Image height in cm or double.NaN for image height is calculated from <see cref="Width"/> keeping the relations between height and width
    /// </summary>
    public double Height { get; set; } = double.NaN;

}