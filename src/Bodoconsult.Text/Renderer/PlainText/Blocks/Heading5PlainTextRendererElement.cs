// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Heading5"/> instances
/// </summary>
public class Heading5PlainTextRendererElement : ParagraphBasePlainTextRendererElement
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Heading5PlainTextRendererElement(Heading5 heading5)
    {
        _paragraph = heading5;
    }
}