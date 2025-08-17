using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Heading4"/> instances
/// </summary>
public class Heading4RtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Heading4 _heading4;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Heading4RtfTextRendererElement(Heading4 heading4) : base(heading4)
    {
        _heading4 = heading4;
        ClassName = heading4.StyleName;
    }
}