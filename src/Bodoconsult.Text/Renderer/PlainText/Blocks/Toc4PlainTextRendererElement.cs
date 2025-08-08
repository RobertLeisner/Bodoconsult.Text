// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc4"/> instances
/// </summary>
public class Toc4PlainTextRendererElement : ParagraphBasePlainTextRendererElement
{

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc4PlainTextRendererElement(Toc4 toc4)
    {
        _paragraph= toc4;
 
}   }

    