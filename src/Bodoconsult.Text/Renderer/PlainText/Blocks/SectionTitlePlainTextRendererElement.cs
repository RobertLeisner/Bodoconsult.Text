// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="SectionTitle"/> instances
/// </summary>
public class SectionTitlePlainTextRendererElement : ITextRendererElement
{
    private readonly SectionTitle _sectionTitle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionTitlePlainTextRendererElement(SectionTitle sectionTitle)
    {
        _sectionTitle = sectionTitle;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, renderer.Content, _sectionTitle.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}