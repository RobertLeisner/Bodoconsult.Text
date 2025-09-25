// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="Equation"/> instances
/// </summary>
public class EquationPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly Equation _equation;

    /// <summary>
    /// Default ctor
    /// </summary>
    public EquationPdfTextRendererElement(Equation equation) : base(equation)
    {
        _equation = equation;
        ClassName = equation.StyleName;
    }
}