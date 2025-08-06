// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="ParagraphJustify"/> instances
/// </summary>
public class ParagraphJustifyPlainTextRendererElement : ITextRendererElement
{
    private readonly ParagraphJustify _paragraphJustify;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ParagraphJustifyPlainTextRendererElement(ParagraphJustify paragraphJustify)
    {
        _paragraphJustify = paragraphJustify;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _paragraphJustify.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}