// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Meta data for a document
/// </summary>
public class DocumentMetaData : Block
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public DocumentMetaData()
    {
        IsSingleton = true;
    }

    /// <summary>
    /// Copyright to print in charts and other items
    /// </summary>
    public string Copyright { get; set; }

    /// <summary>
    /// Name(s) of the author(s)
    /// </summary>
    public string Authors { get; set; }

    /// <summary>
    /// Company name
    /// </summary>
    public string Company { get; set; }

    /// <summary>
    /// Company website
    /// </summary>
    public string CompanyWebsite { get; set; }

    /// <summary>
    /// Path to logo to print in the page header
    /// </summary>
    public string LogoPath { get; set; }

    /// <summary>
    /// Document description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Keywords separated by comma
    /// </summary>
    public string Keywords { get; set; }

    /// <summary>
    /// Table of content (TOC) heading
    /// </summary>
    public string TocHeading { get; set; } = "Table of content";

    /// <summary>
    /// Table of figures (TOF) heading
    /// </summary>
    public string TofHeading { get; set; } = "Table of figures";

    /// <summary>
    /// Table of equations (TOE) heading
    /// </summary>
    public string ToeHeading { get; set; } = "Table of equations";

    /// <summary>
    /// The word written before the page number in a page footer. Default: Page
    /// </summary>
    public string PageName { get; set; } = "Page";

    /// <summary>
    /// Should a TOC section added at the start of the document
    /// </summary>
    public bool IsTocRequired { get; set; }

    /// <summary>
    /// Should add table of figures be added at the start of the document
    /// </summary>
    public bool IsFiguresTableRequired { get; set; }

    /// <summary>
    /// Should add table of equations be added at the start of the document
    /// </summary>
    public bool IsEquationsTableRequired { get; set; }

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="stringBuilder">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder stringBuilder, string indent)
    {
        stringBuilder.AppendLine($"{indent}<DocumentMetaData{GetPropertiesAsAttributes()}/>");
    }

}