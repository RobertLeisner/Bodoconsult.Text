// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="Error"/> instances
/// </summary>
public class ErrorPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly Error _error;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ErrorPdfTextRendererElement(Error error) : base(error)
    {
        _error = error;
        ClassName = error.StyleName;
    }
}