// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="List"/> instances
/// </summary>
public class ListPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public ListPlainTextRendererElement(List list)
    {
        Paragraph = list;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();
        DocumentRendererHelper.RenderBlockChildsToPlain(renderer, sb, Paragraph.ChildBlocks);
        DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, Paragraph.ChildInlines, string.Empty, true);

        // Now add the formatted text to the rendered content
        renderer.Content.Append(sb);
    }

}