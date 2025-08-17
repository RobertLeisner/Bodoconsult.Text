using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Heading5"/> instances
/// </summary>
public class Heading5RtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Heading5 _heading5;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Heading5RtfTextRendererElement(Heading5 heading5) : base(heading5)
    {
        _heading5 = heading5;
        ClassName = heading5.StyleName;
    }
}