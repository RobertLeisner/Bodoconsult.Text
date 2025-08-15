// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="Equation"/> instances
/// </summary>
public class EquationHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly Equation _equation;

    /// <summary>
    /// Default ctor
    /// </summary>
    public EquationHtmlTextRendererElement(Equation equation) : base(equation)
    {
        _equation = equation;
        ClassName = equation.StyleName;
    }
}