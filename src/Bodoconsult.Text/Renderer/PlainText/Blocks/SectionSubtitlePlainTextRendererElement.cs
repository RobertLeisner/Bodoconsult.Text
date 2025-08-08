// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="SectionSubtitle"/> instances
/// </summary>
public class SectionSubtitlePlainTextRendererElement : ParagraphBasePlainTextRendererElement
{

    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionSubtitlePlainTextRendererElement(SectionSubtitle sectionSubtitle)
    {
        _paragraph = sectionSubtitle;
    }


}