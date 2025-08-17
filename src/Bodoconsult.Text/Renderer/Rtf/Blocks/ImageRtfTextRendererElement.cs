using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Image"/> instances
/// </summary>
public class ImageRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Image _image;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ImageRtfTextRendererElement(Image image) : base(image)
    {
        _image = image;
        ClassName = image.StyleName;
    }
}