// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Paragraph"/> instances
/// </summary>
public class ParagraphPlainTextRendererElement: ITextRendererElement
{
    private readonly Paragraph _paragraph;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="paragraph">Paragraph</param>
    public ParagraphPlainTextRendererElement(Paragraph paragraph)
    {
        _paragraph = paragraph;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _paragraph .ChildInlines, string.Empty, true);

        renderer.Content.Append($"{Environment.NewLine}");
    }
}