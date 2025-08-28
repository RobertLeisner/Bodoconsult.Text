// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.IO;
using System.Text;

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

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();

        //if (string.IsNullOrEmpty(LocalCss))
        //{
        //    renderer.Content.Append($"<{TagToUse} class=\"{ClassName}\">");
        //}
        //else
        //{
        //    renderer.Content.Append($"<{TagToUse} class=\"{ClassName}\" style=\"{LocalCss}\">");
        //}

        if (Block is ParagraphBase paragraph)
        {
            var style = (ParagraphStyleBase)renderer.Styleset.FindStyle(paragraph.StyleName);
            renderer.Content.Append($"\\pard\\plain \\q{renderer.Styleset.GetIndexOfStyle(Block.StyleName)} {RtfHelper.GetFormatSettings(style, renderer.Styleset)} {{");
        }
        else
        {
            renderer.Content.Append($"\\pard\\plain \\q{renderer.Styleset.GetIndexOfStyle(Block.StyleName)} {{");
        }

        // Get max height and with for images in twips
        StylesetHelper.GetMaxWidthAndHeight(renderer.Styleset, out var maxWidth, out var maxHeight);

        StylesetHelper.GetWidthAndHeight(MeasurementHelper.GetTwipsFromPx(_image.OriginalWidth), MeasurementHelper.GetTwipsFromPx(_image.OriginalHeight), maxWidth, maxHeight, out var width, out var height);

        // Add the image
        var bytes = ImageHelper.GetBytes(_image.Uri);

        var path = _image.Uri.ToLowerInvariant();

        if (path.EndsWith(".jpg") || path.EndsWith(".jpeg"))
        {
            sb.Append("{\\*\\shppict {\\pict\\jpgblip\\pichgoal1700\\bin ");
        }
        else if (path.EndsWith(".png"))
        {
            sb.Append($"{{\\*\\shppict {{\\pict\\pngblip\\picw{width}\\pich{height}\\picwgoal{maxWidth}\\pichgoal{maxHeight}\\bin ");
        }
        else
        {
            throw new NotSupportedException("Unsupported image format. Use JPEG or PNG images!");
        }

        var str = BitConverter.ToString(bytes, 0).Replace("-", string.Empty);
        sb.Append(str);


        sb.Append("}}\\line ");


        DocumentRendererHelper.RenderInlineChildsToRtf(renderer, sb, Block.ChildInlines);

        renderer.Content.Append(sb);
        renderer.Content.Append($"\\par }}{Environment.NewLine}");
    }



    private void GetWidthAndHeight(int maxWidth, int maxHeight, out int width, out int height)
    {
        if (_image.OriginalWidth > _image.OriginalHeight) // Portrait
        {
            if (_image.OriginalWidth > maxWidth)
            {
                width = maxWidth;
                height = _image.OriginalHeight / _image.OriginalWidth * maxWidth;
            }

            if (_image.OriginalHeight > maxHeight)
            {
                height = maxHeight;
                width = _image.OriginalWidth / _image.OriginalHeight * maxHeight;
            }
            else
            {
                height = _image.OriginalHeight;
                width = _image.OriginalWidth;
            }
        }
        else // Landscape
        {
            if (_image.OriginalHeight > maxHeight)
            {
                height = maxHeight;
                width = _image.OriginalWidth / _image.OriginalHeight * maxHeight;
            }

            if (_image.OriginalWidth > maxWidth)
            {
                width = maxWidth;
                height = _image.OriginalHeight / _image.OriginalWidth * maxWidth;
            }
            else
            {
                height = _image.OriginalHeight;
                width = _image.OriginalWidth;
            }
        }
    }
}