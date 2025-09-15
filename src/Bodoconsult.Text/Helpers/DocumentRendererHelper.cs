// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Renderer;
using System.Collections.Generic;
using System.Text;
using Bodoconsult.Text.Renderer.Html;
using Bodoconsult.Text.Renderer.PlainText;
using Bodoconsult.Text.Renderer.Rtf.Inlines;

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

    /// <summary>
    /// Render child blocks
    /// </summary>
    /// <param name="renderer">Current renderer instance</param>
    /// <param name="sb">Current string</param>
    /// <param name="childBlocks">Child blocks</param>
    public static void RenderBlockChildsToHtml(ITextDocumentRender renderer, StringBuilder sb, List<Block> childBlocks)
    {
        foreach (var inline in childBlocks)
        {
            var rendererElement = renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderIt(renderer);
        }
    }

    /// <summary>
    /// Render table rows
    /// </summary>
    /// <param name="renderer">Current renderer instance</param>
    /// <param name="rows">Child blocks</param>
    public static void RenderRowsToHtml(ITextDocumentRender renderer, List<Row> rows)
    {
        foreach (var inline in rows)
        {
            var rendererElement = renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderIt(renderer);
        }
    }

    /// <summary>
    /// Render child blocks
    /// </summary>
    /// <param name="renderer">Current renderer instance</param>
    /// <param name="childBlocks">Child blocks</param>
    public static void RenderBlockChildsToPlain(ITextDocumentRender renderer, List<Block> childBlocks)
    {
        foreach (var inline in childBlocks)
        {
            var rendererElement = renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderIt(renderer);
        }
    }

    /// <summary>
    /// Render child blocks
    /// </summary>
    /// <param name="renderer">Current renderer instance</param>
    /// <param name="sb">Current string</param>
    /// <param name="childBlocks">Child blocks</param>
    public static void RenderBlockChildsToRtf(ITextDocumentRender renderer, StringBuilder sb, List<Block> childBlocks)
    {
        foreach (var inline in childBlocks)
        {
            var rendererElement = renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderIt(renderer);
        }
    }

    /// <summary>
    /// Render child inlines
    /// </summary>
    /// <param name="renderer">Current renderer instance</param>
    /// <param name="sb">Current string</param>
    /// <param name="childInlines">Child inlines</param>
    public static void RenderInlineChildsToRtf(ITextDocumentRender renderer, StringBuilder sb, List<Inline> childInlines)
    {
        foreach (var inline in childInlines)
        {
            var rendererElement = (InlineRtfTextRendererElementBase)renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderToString(renderer, sb);
        }
    }

    /// <summary>
    /// Render tables cells  to HTML
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    /// <param name="cells">List of all cellss to render</param>
    public static void RenderCellsToHtml(ITextDocumentRender renderer, List<Cell> cells)
    {
        foreach (var inline in cells)
        {
            var rendererElement = (CellHtmlTextRendererElement)renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderIt(renderer);
        }
    }
}

