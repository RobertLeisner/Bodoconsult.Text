// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
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
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, renderer.Content, _image.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}