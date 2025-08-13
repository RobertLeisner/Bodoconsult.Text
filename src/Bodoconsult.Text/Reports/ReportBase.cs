// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using System;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Reports;

/// <summary>
/// Base class for <see cref="Document"/> based reports
/// </summary>
public abstract class ReportBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    protected ReportBase()
    {
        Document = new Document();
    }

    /// <summary>
    /// Ctor to provide a predefined document as base for the reprot
    /// </summary>
    /// <param name="document"></param>
    protected ReportBase(Document document)
    {
        Document = document;
    }

    /// <summary>
    /// Metadata to use for the report
    /// </summary>
    public DocumentMetaData DocumentMetaData { get; private set; } = new();

    /// <summary>
    /// Styleset to use for the report
    /// </summary>
    public Styleset Styleset { get; private set; } = StylesetHelper.CreateDefaultStyleset();

    /// <summary>
    /// Current document to use for report
    /// </summary>
    public Document Document { get; }

    /// <summary>
    /// Current section to add content to
    /// </summary>
    public Section CurrentSection { get; protected set; }


    /// <summary>
    /// Load existing document metadata and replace the existing one
    /// </summary>
    /// <param name="documentMetaData">Document metadata</param>
    public void LoadDocumentMetaData(DocumentMetaData documentMetaData)
    {
        DocumentMetaData = documentMetaData;
    }

    /// <summary>
    /// Load a styleset and replace the existing one
    /// </summary>
    /// <param name="styleset">Styleset to load</param>
    public void LoadStyleset(Styleset styleset)
    {
        Styleset = styleset;
    }

    /// <summary>
    /// Load the styleset and the metadata to the document and create a default section "Body"
    /// </summary>
    public void PrepareTheDocument()
    {
        Document.AddBlock(DocumentMetaData);
        Document.AddBlock(Styleset);
        CreateNewSection("Body");
    }


    /// <summary>
    /// Create a new section in the document
    /// </summary>
    /// <param name="sectionName">Name of the new section</param>
    public void CreateNewSection(string sectionName)
    {
        var section = new Section
        {
            Name = sectionName
        };
        Document.AddBlock(section);
        CurrentSection = section;
    }

    /// <summary>
    /// Add a heading of a certain heading level
    /// </summary>
    /// <param name="content">Content</param>
    /// <param name="headingLevel">Heading level</param>
    public void AddHeading(HeadingLevel headingLevel, string content)
    {
        switch (headingLevel)
        {
            case HeadingLevel.Level1:
                CurrentSection.AddBlock(new Heading1(content));
                break;
            case HeadingLevel.Level2:
                CurrentSection.AddBlock(new Heading2(content));
                break;
            case HeadingLevel.Level3:
                CurrentSection.AddBlock(new Heading3(content));
                break;
            case HeadingLevel.Level4:
                CurrentSection.AddBlock(new Heading4(content));
                break;
            case HeadingLevel.Level5:
                CurrentSection.AddBlock(new Heading5(content));
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(headingLevel), headingLevel, null);
        }
    }

    /// <summary>
    /// Add a paragraph to a report
    /// </summary>
    /// <param name="paragraphType">Paragraph type</param>
    /// <param name="content">Content</param>
    /// <exception cref="ArgumentOutOfRangeException">Paragraph type not found</exception>
    public void AddParagraph(ParagraphType paragraphType, string content)
    {
        switch (paragraphType)
        {
            case ParagraphType.Paragraph:
                CurrentSection.AddBlock(new Paragraph(content));
                break;
            case ParagraphType.ParagraphCenter:
                CurrentSection.AddBlock(new ParagraphCenter(content));
                break;
            case ParagraphType.ParagraphRight:
                CurrentSection.AddBlock(new ParagraphRight(content));
                break;
            case ParagraphType.ParagraphJustify:
                CurrentSection.AddBlock(new ParagraphJustify(content));
                break;
            case ParagraphType.Citation:
                CurrentSection.AddBlock(new Citation(content));
                break;
            case ParagraphType.Code:
                CurrentSection.AddBlock(new Code(content));
                break;
            case ParagraphType.Info:
                CurrentSection.AddBlock(new Info(content));
                break;
            case ParagraphType.Warning:
                CurrentSection.AddBlock(new Warning(content));
                break;
            case ParagraphType.Error:
                CurrentSection.AddBlock(new Error(content));
                break;
            case ParagraphType.Title:
                CurrentSection.AddBlock(new Title(content));
                break;
            case ParagraphType.SubTitle:
                CurrentSection.AddBlock(new Subtitle(content));
                break;
            case ParagraphType.SectionTitle:
                CurrentSection.AddBlock(new SectionTitle(content));
                break;
            case ParagraphType.SectionSubtitle:
                CurrentSection.AddBlock(new SectionSubtitle(content));
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(paragraphType), paragraphType, null);
        }
    }

    /// <summary>
    /// Create the full report. Implement all logic needed to create the full report you want to get
    /// </summary>
    public virtual void CreateReport()
    {
        throw new NotSupportedException("Override this method in your derived report class");
    }
}

/// <summary>
/// Heading level enum
/// </summary>
public enum HeadingLevel
{
    /// <summary>
    /// Heading level 1
    /// </summary>
    Level1,
    /// <summary>
    /// Heading level 2
    /// </summary>
    Level2,
    /// <summary>
    /// Heading level 3
    /// </summary>
    Level3,
    /// <summary>
    /// Heading level 4
    /// </summary>
    Level4,
    /// <summary>
    /// Heading level 5
    /// </summary>
    Level5
}

/// <summary>
/// Paragraph style
/// </summary>
public enum ParagraphType
{
    /// <summary>
    /// Left aligned paragraph
    /// </summary>
    Paragraph,
    /// <summary>
    /// Centered paragraph
    /// </summary>
    ParagraphCenter,
    /// <summary>
    /// Justified paragraph
    /// </summary>
    ParagraphJustify,
    /// <summary>
    /// Right aligned paragraph
    /// </summary>
    ParagraphRight,
    /// <summary>
    /// Paragraph containing a citation
    /// </summary>
    Citation,
    /// <summary>
    /// Paragraph containing a code piece
    /// </summary>
    Code,
    /// <summary>
    /// Paragraph containing an info message
    /// </summary>
    Info,
    /// <summary>
    /// Paragraph containing a warning message
    /// </summary>
    Warning,
    /// <summary>
    /// Paragraph containing an error message
    /// </summary>
    Error,
    /// <summary>
    /// Title
    /// </summary>
    Title,
    /// <summary>
    /// Subtitle
    /// </summary>
    SubTitle,
    /// <summary>
    /// Section title
    /// </summary>
    SectionTitle,
    /// <summary>
    /// Section subtitle
    /// </summary>
    SectionSubtitle

}