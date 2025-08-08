// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Heading4"/> instances
/// </summary>
public class Heading4PlainTextRendererElement : ParagraphBasePlainTextRendererElement
{

    /// <summary>
    /// Default ctor
    /// </summary>
    public Heading4PlainTextRendererElement(Heading4 heading4)
    {
        _paragraph = heading4;
    }
}