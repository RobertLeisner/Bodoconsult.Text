// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using Bodoconsult.Text.Renderer.PlainText;
using System.Text;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Plain rendering element for <see cref="ToeSection"/> instances
/// </summary>
public class ToeSectionPlainTextRendererElement : ITextRendererElement
{
    private readonly ToeSection _toeSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ToeSectionPlainTextRendererElement(ToeSection toeSection)
    {
        _toeSection = toeSection;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();

        DocumentRendererHelper.RenderInlineBlocksToPlain(renderer, sb, _toeSection.ChildBlocks, string.Empty, true);

        DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _toeSection.ChildInlines, string.Empty, true);
        renderer.Content.Append(sb);
    }
}