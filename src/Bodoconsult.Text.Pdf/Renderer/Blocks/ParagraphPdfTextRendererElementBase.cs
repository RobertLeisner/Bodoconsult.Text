// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Pdf.Helpers;
using Paragraph = MigraDoc.DocumentObjectModel.Paragraph;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// Base renderer implementation for HTML elements
/// </summary>
public abstract class ParagraphPdfTextRendererElementBase : PdfTextRendererElementBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="block">Current block</param>
    protected ParagraphPdfTextRendererElementBase(Block block) : base(block)
    {
    }

    /// <summary>
    /// Current paragraph to render in
    /// </summary>
    public Paragraph Paragraph { get; set; }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(PdfTextDocumentRenderer renderer)
    {
        PdfDocumentRendererHelper.RenderBlockInlinesToPdf(renderer, Block.ChildInlines, Paragraph);
    }
}