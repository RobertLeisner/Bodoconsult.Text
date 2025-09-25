// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Pdf.Helpers;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="TotSection"/> instances
/// </summary>
public class TotSectionPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly TotSection _totSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TotSectionPdfTextRendererElement(TotSection totSection) : base(totSection)
    {
        _totSection = totSection;
        ClassName = totSection.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(PdfTextDocumentRenderer renderer)
    {
        if (_totSection.ChildBlocks.Count == 0)
        {
            return;
        }

        renderer.PdfDocument.CreateTotSection();

        renderer.PdfDocument.AddParagraph(renderer.Document.DocumentMetaData.TotHeading);

        PdfDocumentRendererHelper.RenderBlockChildsToPdf(renderer, Block.ChildBlocks);
    }
}