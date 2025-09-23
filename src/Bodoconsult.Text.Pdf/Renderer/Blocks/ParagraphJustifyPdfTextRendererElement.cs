// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="ParagraphJustify"/> instances
/// </summary>
public class ParagraphJustifyPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly ParagraphJustify _paragraphJustify;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ParagraphJustifyPdfTextRendererElement(ParagraphJustify paragraphJustify) : base(paragraphJustify)
    {
        _paragraphJustify = paragraphJustify;
        ClassName = paragraphJustify.StyleName;
    }
}