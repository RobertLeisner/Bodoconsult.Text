using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Equation"/> instances
/// </summary>
public class EquationPlainTextRendererElement : ITextRendererElement
{
    private readonly Equation _Equation;

    /// <summary>
    /// Default ctor
    /// </summary>
    public EquationPlainTextRendererElement(Equation Equation)
    {
        _Equation = Equation;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Equation.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}