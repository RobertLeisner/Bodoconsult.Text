using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="ToeSection"/> instances
/// </summary>
public class ToeSectionRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly ToeSection _toeSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ToeSectionRtfTextRendererElement(ToeSection toeSection) : base(toeSection)
    {
        _toeSection = toeSection;
        ClassName = toeSection.StyleName;
    }
}