// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using System.Text;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Image"/> instances
/// </summary>
public class ImagePlainTextRendererElement : ITextRendererElement
{
    private readonly Image _image;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ImagePlainTextRendererElement(Image image)
    {
        _image = image;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        var sb = new StringBuilder();
        DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _image.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"![{sb}]({_image.Uri} \"{sb}\"){Environment.NewLine}{Environment.NewLine}");
    }
}