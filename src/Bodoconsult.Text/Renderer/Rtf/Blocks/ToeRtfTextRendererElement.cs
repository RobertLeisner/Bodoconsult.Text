// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Toe"/> instances
/// </summary>
public class ToeRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Toe _toe;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ToeRtfTextRendererElement(Toe toe) : base(toe)
    {
        _toe = toe;
        ClassName = toe.StyleName;
    }
}