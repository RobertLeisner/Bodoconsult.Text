// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="ParagraphRight"/> instances
/// </summary>
public class ParagraphRightPlainTextRendererElement : ITextRendererElement
{
    private readonly ParagraphRight _paragraphRight;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ParagraphRightPlainTextRendererElement(ParagraphRight paragraphRight)
    {
        _paragraphRight = paragraphRight;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, renderer.Content, _paragraphRight.ChildInlines, tag: string.Empty, isBlock: true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}