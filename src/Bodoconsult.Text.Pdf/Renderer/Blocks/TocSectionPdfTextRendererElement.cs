// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Pdf.Helpers;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="TocSection"/> instances
/// </summary>
public class TocSectionPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly TocSection _tocSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TocSectionPdfTextRendererElement(TocSection tocSection) : base(tocSection)
    {
        _tocSection = tocSection;
        ClassName = tocSection.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(PdfTextDocumentRenderer renderer)
    {
        if (_tocSection.ChildBlocks.Count == 0)
        {
            return;
        }

        renderer.PdfDocument.CreateTocSection();

        PdfDocumentRendererHelper.RenderBlockChildsToPdf(renderer, Block.ChildBlocks);
    }
}