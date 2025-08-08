// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using System;
using System.Diagnostics;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Paragraph"/> instances
/// </summary>
public class ParagraphPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="paragraph">Paragraph</param>
    public ParagraphPlainTextRendererElement(Paragraph paragraph)
    {
        _paragraph = paragraph;
    }
}