// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Pdf.Interfaces;
using Bodoconsult.Text.Pdf.Renderer;
using Bodoconsult.Text.Pdf.Renderer.Inlines;
using MigraDoc.DocumentObjectModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Paragraph = MigraDoc.DocumentObjectModel.Paragraph;

namespace Bodoconsult.Text.Pdf.Helpers;

/// <summary>
/// Helper class for document rendering
/// </summary>
public static class PdfDocumentRendererHelper
{
    /// <summary>
    /// Render the child blocks of a block to PDF
    /// </summary>
    /// <param name="renderer">Curent PDF renderer</param>
    /// <param name="childBlocks">Child blocks to render</param>
    public static void RenderBlockChildsToPdf(PdfTextDocumentRenderer renderer, ReadOnlyLdmlList<Block> childBlocks)
    {
        foreach (var block in childBlocks)
        {
            var rendererElement = renderer.PdfTextRendererElementFactory.CreateInstancePdf(block);
            rendererElement.RenderIt(renderer);
        }
    }

    public static void RenderBlockInlinesToPdf(PdfTextDocumentRenderer renderer, ReadOnlyLdmlList<Inline> childInlines, Paragraph paragraph)
    {
        if (paragraph == null)
        {
            throw new ArgumentNullException(nameof(paragraph));
        }

        foreach (var inline in childInlines)
        {
            var rendererElement = (InlinePdfTextRendererElementBase)renderer.PdfTextRendererElementFactory.CreateInstancePdf(inline);
            rendererElement.RenderIt(renderer, paragraph);
        }
    }

    public static void RenderBlockInlinesToStringForPdf(PdfTextDocumentRenderer renderer, List<Inline> childInlines, StringBuilder sb)
    {
        foreach (var inline in childInlines)
        {
            var rendererElement = (InlinePdfTextRendererElementBase)renderer.PdfTextRendererElementFactory.CreateInstancePdf(inline);
            rendererElement.RenderToString(sb);
        }
    }
}