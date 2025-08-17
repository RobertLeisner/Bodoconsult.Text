// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Text;
using System.Xml.Linq;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Base renderer implementation for Rtf elements
/// </summary>
public class RtfTextRendererElementBase : ITextRendererElement
{
    /// <summary>
    /// Current block to renderer
    /// </summary>
    public Block Block { get; private set; }

    /// <summary>
    /// CSS class name
    /// </summary>
    public string ClassName { get; protected set; }

    /// <summary>
    /// CSS to be added to the local tag
    /// </summary>
    public string LocalCss { get; set; }

    /// <summary>
    /// Rtf tag to use for rendering
    /// </summary>
    protected string TagToUse = "p";

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="block">Current block</param>
    public RtfTextRendererElementBase(Block block)
    {
        Block = block;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public virtual void RenderIt(ITextDocumentRender renderer)
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

        renderer.Content.Append($"\\pard\\plain \\s{renderer.Styleset.GetIndexOfStyle(Block.StyleName)} ");

        DocumentRendererHelper.RenderBlockChildsToRtf(renderer, sb, Block.ChildBlocks);

        DocumentRendererHelper.RenderInlineChildsToRtf(renderer, sb, Block.ChildInlines);
        renderer.Content.Append(sb);
        renderer.Content.Append($"\\par{Environment.NewLine}");
    }
}