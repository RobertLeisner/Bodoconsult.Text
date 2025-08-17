using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Citation"/> instances
/// </summary>
public class CitationRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Citation _citation;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CitationRtfTextRendererElement(Citation citation) : base(citation)
    {
        _citation = citation;
        ClassName = citation.StyleName;
    }
}