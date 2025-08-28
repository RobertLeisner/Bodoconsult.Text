// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Section"/> instances
/// </summary>
public class SectionRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Section _section;

    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionRtfTextRendererElement(Section section) : base(section)
    {
        _section = section;
        ClassName = section.StyleName;
    }
}