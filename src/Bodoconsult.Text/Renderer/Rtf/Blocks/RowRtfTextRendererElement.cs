// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Row"/> instances
/// </summary>
public class RowRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Row _row;

    /// <summary>
    /// Default ctor
    /// </summary>
    public RowRtfTextRendererElement(Row row) : base(row)
    {
        _row = row;
        ClassName = row.StyleName;
    }
}