// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Renderer;
using System;
using System.Collections.Generic;

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
    /// <param name="childInlines">Current child inlines</param>
    /// <param name="tag">Tag to add before and after the inlines</param>
    /// <param name="isBlock">Parent element is a block</param>
    public static void RenderInlineChilds(ITextDocumentRender renderer, List<Inline> childInlines, string tag = null, bool isBlock = false)
    {

        if (!string.IsNullOrEmpty(tag))
        {
            renderer.Content.Append(tag);
        }

        foreach (var inline in childInlines)
        {
            var rendererElement = renderer.TextRendererElementFactory.CreateInstance(inline);
            rendererElement.RenderIt(renderer);
        }

        if (!string.IsNullOrEmpty(tag))
        {
            renderer.Content.Append(tag);
        }

        if (isBlock)
        {
            renderer.Content.Append($"{Environment.NewLine}");
        }
    }
}