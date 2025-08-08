// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc5"/> instances
/// </summary>
public class Toc5PlainTextRendererElement : ParagraphBasePlainTextRendererElement
{

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc5PlainTextRendererElement(Toc5 toc5)
    {
        _paragraph = toc5;
    }

}