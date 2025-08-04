// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for document element
/// </summary>
public class DocumentStyle: StyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public DocumentStyle()
    {
        TagToUse = string.Intern("DocumentStyle");
        Name = TagToUse;
    }

    /// <summary>
    /// Name of the paper format, i.e. A4, Letter, Legal
    /// </summary>
    public string PaperFormatName { get; set; } = "DIN A4";

    /// <summary>
    /// Page width in cm
    /// </summary>
    public double PageWidth { get; set; } = 21.0;

    /// <summary>
    /// Page height in cm
    /// </summary>
    public double PageHeight { get; set; } = 29.4;

    /// <summary>
    /// Left margin in cm
    /// </summary>
    public double MarginLeft { get; set; } = 3.0;

    /// <summary>
    /// Left margin in cm
    /// </summary>
    public double MarginTop { get; set; } = 2.0;

    /// <summary>
    /// Left margin in cm
    /// </summary>
    public double MarginRight { get; set; } = 2.0;

    /// <summary>
    /// Left margin in cm
    /// </summary>
    public double MarginBottom { get; set; } = 2.0;
}
