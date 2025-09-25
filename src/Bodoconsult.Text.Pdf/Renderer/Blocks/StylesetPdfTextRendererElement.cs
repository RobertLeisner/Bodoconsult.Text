// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Text;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Interfaces;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="Styleset"/> instances
/// </summary>
public class StylesetPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly Styleset _styleset;

    /// <summary>
    /// Default ctor
    /// </summary>
    public StylesetPdfTextRendererElement(Styleset styleset) : base(styleset)
    {
        _styleset = styleset;
        ClassName = styleset.StyleName;
    }
}