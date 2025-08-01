// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for section element
/// </summary>
public class SectionStyle : StyleBase
{

    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionStyle()
    {
        TagToUse = string.Intern("Section");
        Name = TagToUse;
    }

    /// <summary>
    /// Name of the paper format, i.e. A4, Letter, Legal. If null the value from <see cref="Document"/> is taken
    /// </summary>
    public string PaperFormatName { get; set; } = null;

    /// <summary>
    /// Page width in cm. If double.NaN the value from <see cref="Document"/> is taken
    /// </summary>
    public double PageWidth { get; set; } = double.NaN;

    /// <summary>
    /// Page height in cm. If double.NaN the value from <see cref="Document"/> is taken
    /// </summary>
    public double PageHeight { get; set; } = double.NaN;

    /// <summary>
    /// Left margin in cm. If double.NaN the value from <see cref="Document"/> is taken
    /// </summary>
    public double MarginLeft { get; set; } = double.NaN;

    /// <summary>
    /// Left margin in cm. If double.NaN the value from <see cref="Document"/> is taken
    /// </summary>
    public double MarginTop { get; set; } = double.NaN;

    /// <summary>
    /// Left margin in cm. If double.NaN the value from <see cref="Document"/> is taken
    /// </summary>
    public double MarginRight { get; set; } = double.NaN;

    /// <summary>
    /// Left margin in cm. If double.NaN the value from <see cref="Document"/> is taken
    /// </summary>
    public double MarginBottom { get; set; } = double.NaN;

}
