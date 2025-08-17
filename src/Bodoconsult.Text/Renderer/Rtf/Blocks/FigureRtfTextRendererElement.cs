using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Figure"/> instances
/// </summary>
public class FigureRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Figure _figure;

    /// <summary>
    /// Default ctor
    /// </summary>
    public FigureRtfTextRendererElement(Figure figure) : base(figure)
    {
        _figure = figure;
        ClassName = figure.StyleName;
    }
}