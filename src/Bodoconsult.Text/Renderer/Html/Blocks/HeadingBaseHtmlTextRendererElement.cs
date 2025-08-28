// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Text;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="HeadingBase"/> instances
/// </summary>
public class HeadingBaseHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly HeadingBase _headingBase;

    /// <summary>
    /// Default ctor
    /// </summary>
    public HeadingBaseHtmlTextRendererElement(HeadingBase headingBase) : base(headingBase)
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

        if (string.IsNullOrEmpty(LocalCss))
        {
            renderer.Content.Append($"<{TagToUse} class=\"{ClassName}\">");
        }
        else
        {
            renderer.Content.Append($"<{TagToUse} class=\"{ClassName}\" style=\"{LocalCss}\">");
        }

        sb.Append(_headingBase.CurrentPrefix);

        //DocumentRendererHelper.RenderBlockChildsToHtml(renderer, sb, Block.ChildBlocks);

        DocumentRendererHelper.RenderInlineChildsToHtml(renderer, sb, Block.ChildInlines);
        renderer.Content.Append(sb);
        renderer.Content.Append($"</{TagToUse}>{Environment.NewLine}");
    }
}