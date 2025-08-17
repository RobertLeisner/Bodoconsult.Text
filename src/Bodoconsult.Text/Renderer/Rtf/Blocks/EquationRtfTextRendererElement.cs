using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Equation"/> instances
/// </summary>
public class EquationRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Equation _equation;

    /// <summary>
    /// Default ctor
    /// </summary>
    public EquationRtfTextRendererElement(Equation equation) : base(equation)
    {
        _equation = equation;
        ClassName = equation.StyleName;
    }
}