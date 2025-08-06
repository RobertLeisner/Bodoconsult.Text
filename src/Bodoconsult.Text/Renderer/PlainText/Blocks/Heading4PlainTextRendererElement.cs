// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Heading4"/> instances
/// </summary>
public class Heading4PlainTextRendererElement : ITextRendererElement
{
    private readonly Heading4 _heading4;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Heading4PlainTextRendererElement(Heading4 heading4)
    {
        _heading4 = heading4;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _heading4.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}