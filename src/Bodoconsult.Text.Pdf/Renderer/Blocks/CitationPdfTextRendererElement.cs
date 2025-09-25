// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Interfaces;
using Bodoconsult.Text.Pdf.Helpers;
using System;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="Citation"/> instances
/// </summary>
public class CitationPdfTextRendererElement : ParagraphPdfTextRendererElementBase
{
    private readonly Citation _citation;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CitationPdfTextRendererElement(Citation citation) : base(citation)
    {
        _citation = citation;
        ClassName = citation.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(PdfTextDocumentRenderer renderer)
    {
        Paragraph = renderer.PdfDocument.AddCitation(string.Empty, _citation.Source);
        base.RenderIt(renderer);
    }
}

