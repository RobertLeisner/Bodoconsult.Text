// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Plain text rendering element for <see cref="TocSection"/> instances
/// </summary>
public class TocSectionPlainTextRendererElement : ITextRendererElement
{
    private readonly TocSection _tocSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TocSectionPlainTextRendererElement(TocSection tocSection) 
    {
        _tocSection = tocSection;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();

        DocumentRendererHelper.RenderBlockChildsToPlain(renderer, sb, _tocSection.ChildBlocks);

        DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _tocSection.ChildInlines, string.Empty, true);
        renderer.Content.Append(sb);
    }
}