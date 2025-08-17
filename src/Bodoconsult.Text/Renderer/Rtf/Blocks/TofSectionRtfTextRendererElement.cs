using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="TofSection"/> instances
/// </summary>
public class TofSectionRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly TofSection _tofSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TofSectionRtfTextRendererElement(TofSection tofSection) : base(tofSection)
    {
        _tofSection = tofSection;
        ClassName = tofSection.StyleName;
    }
}