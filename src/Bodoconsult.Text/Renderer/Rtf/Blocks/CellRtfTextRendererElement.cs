// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Cell"/> instances
/// </summary>
public class CellRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Cell _cell;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CellRtfTextRendererElement(Cell cell) : base(cell)
    {
        _cell = cell;
        ClassName = cell.StyleName;
    }
}