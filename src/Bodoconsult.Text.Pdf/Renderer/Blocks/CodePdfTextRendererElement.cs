// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="Code"/> instances
/// </summary>
public class CodePdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly Code _code;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CodePdfTextRendererElement(Code code) : base(code)
    {
        _code = code;
        ClassName = code.StyleName;
    }
}