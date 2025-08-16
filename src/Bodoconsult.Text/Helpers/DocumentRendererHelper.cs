// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Renderer;
using System.Collections.Generic;
using System.Text;
using Bodoconsult.Text.Renderer.Html;
using Bodoconsult.Text.Renderer.PlainText;

namespace Bodoconsult.Text.Helpers;

/// <summary>
/// Helper class for document rendering
/// </summary>
public class DocumentRendererHelper
{
    /// <summary>
    /// Render the child inlines
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    /// <param name="sb">String to render the nested inlines in</param>
    /// <param name="childInlines">Current child inlines</param>
    /// <param name="tag">Tag to add before and after the inlines</param>
    /// <param name="isBlock">Parent element is a block</param>
    public static void RenderInlineChildsToPlainText(ITextDocumentRender renderer, StringBuilder sb, List<Inline> childInlines,
        string tag = null, bool isBlock = false)
    {

        if (!string.IsNullOrEmpty(tag))
        {
            sb.Append(tag);
        }

        foreach (var inline in childInlines)
        {
            var rendererElement = (InlinePlainTextRendererElementBase)renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderToString(renderer, sb);
        }

        if (!string.IsNullOrEmpty(tag))
        {
            sb.Append(tag);
        }
    }

    /// <summary>
    /// Render the child inlines
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    /// <param name="sb">String to render the nested inlines in</param>
    /// <param name="childInlines">Current child inlines</param>
    /// <param name="tag">Tag to add before and after the inlines</param>
    /// <param name="isBlock">Parent element is a block</param>
    public static void RenderInlineChildsToHtml(ITextDocumentRender renderer, StringBuilder sb, List<Inline> childInlines,
        string tag = null, bool isBlock = false)
    {

        if (!string.IsNullOrEmpty(tag))
        {
            sb.Append(tag);
        }

        foreach (var inline in childInlines)
        {
            var rendererElement = (InlineHtmlTextRendererElementBase)renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderToString(renderer, sb);
        }

        if (!string.IsNullOrEmpty(tag))
        {
            sb.Append(tag);
        }
    }

    public static void RenderInlineBlocksToHtml(ITextDocumentRender renderer, StringBuilder sb, List<Block> childBlocks, string empty, bool b)
    {
        foreach (var inline in childBlocks)
        {
            var rendererElement = (ITextRendererElement)renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderIt(renderer);
        }
    }

    public static void RenderInlineBlocksToPlain(ITextDocumentRender renderer, StringBuilder sb, List<Block> childBlocks, string empty, bool b)
    {
        foreach (var inline in childBlocks)
        {
            var rendererElement = (ITextRendererElement)renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderIt(renderer);
        }
    }
}