// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Heading1"/> instances
/// </summary>

public class Heading1PlainTextRendererElement : ITextRendererElement
{
    private readonly Heading1 _paragraph;

    private const string HeadingDecoration = "****************************";

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="paragraph">Paragraph</param>
    public Heading1PlainTextRendererElement(Heading1 paragraph)
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

        DocumentRendererHelper.RenderInlineChilds(renderer, _paragraph.ChildInlines, string.Empty, true);

        renderer.Content.Append($"{HeadingDecoration}{Environment.NewLine}{Environment.NewLine}");
    }
}