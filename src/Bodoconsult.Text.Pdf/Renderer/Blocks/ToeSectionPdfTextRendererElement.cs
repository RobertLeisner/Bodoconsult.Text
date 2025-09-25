// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Pdf.Helpers;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="ToeSection"/> instances
/// </summary>
public class ToeSectionPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly ToeSection _toeSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ToeSectionPdfTextRendererElement(ToeSection toeSection) : base(toeSection)
    {
        _toeSection = toeSection;
        ClassName = toeSection.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(PdfTextDocumentRenderer renderer)
    {
        if (_toeSection.ChildBlocks.Count == 0)
        {
            return;
        }

        renderer.PdfDocument.CreateToeSection();

        PdfDocumentRendererHelper.RenderBlockChildsToPdf(renderer, Block.ChildBlocks);
    }
}