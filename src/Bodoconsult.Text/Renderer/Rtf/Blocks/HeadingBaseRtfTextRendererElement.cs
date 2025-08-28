// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Text;

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

        sb.Append(_headingBase.CurrentPrefix);

        //DocumentRendererHelper.RenderBlockChildsToRtf(renderer, sb, Block.ChildBlocks);

        DocumentRendererHelper.RenderInlineChildsToRtf(renderer, sb, Block.ChildInlines);

        CleanRtfString(sb);

        renderer.Content.Append(sb);
        renderer.Content.Append($"\\par }}{Environment.NewLine}");
    }
}