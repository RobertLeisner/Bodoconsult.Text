// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Text;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Interfaces;

namespace Bodoconsult.Text.Pdf.Renderer.Styles;

/// <summary>
/// HTML rendering element for <see cref="RowStyle"/> instances
/// </summary>
public class RowStylePdfTextRendererElement : PdfStyleTextRendererElementBase
{
    private readonly RowStyle _rowStyle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public RowStylePdfTextRendererElement(RowStyle rowStyle)
    {
        _rowStyle = rowStyle;
        ClassName = "RowStyle";
    }
}