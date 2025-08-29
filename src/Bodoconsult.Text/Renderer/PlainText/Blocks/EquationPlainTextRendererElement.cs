// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Text;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Equation"/> instances
/// </summary>
public class EquationPlainTextRendererElement : ITextRendererElement
{
    private readonly Equation _equation;

    /// <summary>
    /// Default ctor
    /// </summary>
    public EquationPlainTextRendererElement(Equation equation)
    {
        _equation = equation;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        var sb = new StringBuilder();
        sb.Append(_equation.CurrentPrefix);
        DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _equation.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"![{sb}]({_equation.Uri} \"{sb}\"){Environment.NewLine}{Environment.NewLine}");
    }
}