// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="List"/> instances
/// </summary>
public class ListPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{
  

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListPlainTextRendererElement(List list)
    {
        _paragraph = list;
    }

}