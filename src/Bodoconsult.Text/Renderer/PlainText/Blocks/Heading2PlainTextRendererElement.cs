// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Heading2"/> instances
/// </summary>

public class Heading2PlainTextRendererElement : ITextRendererElement
{
    private readonly Heading2 _paragraph;

    private const string HeadingDecoration = "****************";

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="paragraph">Paragraph</param>
    public Heading2PlainTextRendererElement(Heading2 paragraph)
    {
        _paragraph = paragraph;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        renderer.Content.Append($"{Environment.NewLine}{Environment.NewLine}{Environment.NewLine}{HeadingDecoration}{Environment.NewLine}");

        DocumentRendererHelper.RenderInlineChilds(renderer, _paragraph.ChildInlines, null, true);

        renderer.Content.Append($"{Environment.NewLine}{HeadingDecoration}{Environment.NewLine}{Environment.NewLine}");
    }
}