// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Text;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// Base renderer implementation for HTML elements
/// </summary>
public class HtmlTextRendererElementBase: ITextRendererElement
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
    /// HTML tag to use for rendering
    /// </summary>
    protected string TagToUse = "p";

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="block">Current block</param>
    public HtmlTextRendererElementBase(Block block)
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

        DocumentRendererHelper.RenderInlineBlocksToHtml(renderer, sb, Block.ChildBlocks, string.Empty, true);

        DocumentRendererHelper.RenderInlineChildsToHtml(renderer, sb, Block.ChildInlines, string.Empty, true);
        renderer.Content.Append($"<{TagToUse} class=\"{ClassName}\">{sb}</{TagToUse}>{Environment.NewLine}");
    }
}