// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="SectionTitle"/> instances
/// </summary>
public class SectionTitlePlainTextRendererElement : ParagraphBasePlainTextRendererElement
{
   

    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionTitlePlainTextRendererElement(SectionTitle sectionTitle)
    {
        _paragraph = sectionTitle;
    }

}