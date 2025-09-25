// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="Figure"/> instances
/// </summary>
public class FigurePdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly Figure _figure;

    /// <summary>
    /// Default ctor
    /// </summary>
    public FigurePdfTextRendererElement(Figure figure) : base(figure)
    {
        _figure = figure;
        ClassName = figure.StyleName;
    }
}