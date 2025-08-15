// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="Image"/> instances
/// </summary>
public class ImageHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly Image _image;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ImageHtmlTextRendererElement(Image image) : base(image)
    {
        _image = image;
        ClassName = image.StyleName;
    }
}