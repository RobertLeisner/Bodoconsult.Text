// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="Table"/> instances
/// </summary>
public class TablePdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly Table _table;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TablePdfTextRendererElement(Table table) : base(table)
    {
        _table = table;
        ClassName = "TableStyle";
    }
}