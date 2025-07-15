// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using MigraDoc.DocumentObjectModel;

namespace Bodoconsult.Pdf.Stylesets;

/// <summary>
/// Interface for stylesets used to format PDF files created by PdfSharp and MigraDoc
/// </summary>
public interface IStyleSet
{
    /// <summary>
    /// Normal paragraphs (default style)
    /// </summary>
    Style Normal { get; }

    /// <summary>
    /// Style used a table base. Do NOT change this style
    /// </summary>
    Style NormalTable { get; }

    /// <summary>
    /// Title
    /// </summary>
    Style Title { get; }

    /// <summary>
    /// Heading level 1
    /// </summary>
    Style Heading1 { get; }

    /// <summary>
    /// Heading level 2
    /// </summary>
    Style Heading2 { get; }

    /// <summary>
    /// Heading level 3
    /// </summary>
    Style Heading3 { get; }

    /// <summary>
    /// Heading level 4
    /// </summary>
    Style Heading4 { get; }

    /// <summary>
    /// No heading 1 for small tables
    /// </summary>
    Style NoHeading1 { get; }

    /// <summary>
    /// Chart title style
    /// </summary>
    Style ChartTitle { get; }

    /// <summary>
    /// Chart y-axis label style
    /// </summary>
    Style ChartYLabel { get; }

    /// <summary>
    /// Style used for tables
    /// </summary>
    Style Table { get; }

    /// <summary>
    /// Style for TOC heading 1
    /// </summary>
    Style Toc1 { get; }

    /// <summary>
    /// Style for TOC heading 2
    /// </summary>
    Style Toc2 { get; }

    /// <summary>
    /// Style for TOC heading 3
    /// </summary>
    Style Toc3 { get; }

    /// <summary>
    /// Style for TOC heading 4
    /// </summary>
    Style Toc4 { get; }

    /// <summary>
    /// Style for TOC title
    /// </summary>
    Style TocHeading1 { get; }

    /// <summary>
    /// Page header style
    /// </summary>
    Style Header { get; }

    /// <summary>
    /// Details style
    /// </summary>
    Style Details { get; }

    /// <summary>
    /// Chart cell style
    /// </summary>
    Style ChartCell { get; }

    /// <summary>
    /// Page footer style
    /// </summary>
    Style Footer { get; }

    /// <summary>
    /// Style for code segement paragraphs
    /// </summary>
    Style Code { get; }

    /// <summary>
    /// A style for bulleted lists
    /// </summary>
    Style Bullet1 { get; }

    /// <summary>
    /// Current page setup
    /// </summary>
    PageSetup PageSetup { get; set; }
}