// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Styles;

/// <summary>
/// Rtf rendering element for <see cref="CitationStyle"/> instances
/// </summary>
public class CitationStyleRtfTextRendererElement : RtfParagraphStyleTextRendererElementBase
{
    private readonly ParagraphStyleBase _citationStyle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CitationStyleRtfTextRendererElement(CitationStyle citationStyle) : base(citationStyle)
    {
        _citationStyle = citationStyle;
        ClassName = "CitationStyle";
    }
}