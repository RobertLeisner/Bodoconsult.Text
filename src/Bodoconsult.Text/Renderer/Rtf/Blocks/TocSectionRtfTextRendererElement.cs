using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="TocSection"/> instances
/// </summary>
public class TocSectionRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly TocSection _tocSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TocSectionRtfTextRendererElement(TocSection tocSection) : base(tocSection)
    {
        _tocSection = tocSection;
        ClassName = tocSection.StyleName;
    }
}