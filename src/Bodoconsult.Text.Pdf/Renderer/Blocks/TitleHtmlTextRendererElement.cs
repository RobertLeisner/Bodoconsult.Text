// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="Title"/> instances
/// </summary>
public class TitlePdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly Title _title;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TitlePdfTextRendererElement(Title title) : base(title)
    {
        _title = title;
        ClassName = title.StyleName;
    }
}