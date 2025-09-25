// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Pdf.PdfSharp;
using Bodoconsult.Pdf.Stylesets;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Interfaces;
using Bodoconsult.Text.Pdf.Interfaces;
using Bodoconsult.Text.Renderer;
using PdfSharp.Fonts;
using System;

namespace Bodoconsult.Text.Pdf.Renderer;

/// <summary>
/// Render a <see cref="Document"/> to a PDF file
/// </summary>
public class PdfTextDocumentRenderer : BaseDocumentRenderer
{
    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="document">Document to render</param>
    /// <param name="textRendererElementFactory">Current factory for text renderer elements</param>
    /// <param name="fontResolver">Current font resolver</param>
    public PdfTextDocumentRenderer(Document document, ITextRendererElementFactory textRendererElementFactory, IFontResolver fontResolver) : base(document)
    {
        PdfTextRendererElementFactory = (IPdfTextRendererElementFactory)textRendererElementFactory;
        IStyleSet styleSet = new DefaultStyleSet();
        PdfDocument = new PdfBuilder(styleSet, fontResolver);
    }

    /// <summary>
    /// The current PDF document
    /// </summary>
    public PdfBuilder PdfDocument { get; }

    /// <summary>
    /// Current styleset
    /// </summary>
    public IStyleSet StyleSet { get; set; }

    /// <summary>
    /// Current text renderer element factory
    /// </summary>
    public IPdfTextRendererElementFactory PdfTextRendererElementFactory { get; protected set; }

    /// <summary>
    /// Render the document
    /// </summary>
    public override void RenderIt()
    {
        var rendererElement = PdfTextRendererElementFactory.CreateInstancePdf(Document);
        rendererElement.RenderIt(this);
    }

    /// <summary>
    /// Save the rendered document as file
    /// </summary>
    /// <param name="fileName">Full file path. Existing file will be overwritten</param>
    public override void SaveAsFile(string fileName)
    {
        PdfDocument.RenderToPdf(fileName, false);
    }
}