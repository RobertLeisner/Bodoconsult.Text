// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Citation"/> instances
/// </summary>
public class CitationPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{
  
    /// <summary>
    /// Default ctor
    /// </summary>
    public CitationPlainTextRendererElement(Citation citation)
    {
        Paragraph= citation;
    }
}

