using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Tof"/> instances
/// </summary>
public class TofRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Tof _tof;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TofRtfTextRendererElement(Tof tof) : base(tof)
    {
        _tof = tof;
        ClassName = tof.StyleName;
    }
}