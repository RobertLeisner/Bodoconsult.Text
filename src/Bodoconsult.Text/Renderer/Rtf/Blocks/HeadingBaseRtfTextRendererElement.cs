using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="HeadingBase"/> instances
/// </summary>
public class HeadingBaseRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly HeadingBase _headingBase;

    /// <summary>
    /// Default ctor
    /// </summary>
    public HeadingBaseRtfTextRendererElement(HeadingBase headingBase) : base(headingBase)
    {
        _headingBase = headingBase;
        ClassName = headingBase.StyleName;
    }
}