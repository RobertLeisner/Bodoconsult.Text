// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Heading1"/> instances
/// </summary>

public class Heading1PlainTextRendererElement : ParagraphBasePlainTextRendererElement
{
    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="paragraph">Paragraph</param>
    public Heading1PlainTextRendererElement(Heading1 paragraph)
    {
        _paragraph = paragraph;
    }
}