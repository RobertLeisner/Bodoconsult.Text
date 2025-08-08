// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc1"/> instances
/// </summary>
public class Toc1PlainTextRendererElement : ParagraphBasePlainTextRendererElement
{
   

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc1PlainTextRendererElement(Toc1 toc1)
    {
        _paragraph = toc1;
    }
}