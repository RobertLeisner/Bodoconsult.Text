// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Column"/> instances
/// </summary>
public class ColumnRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Column _column;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ColumnRtfTextRendererElement(Column column) : base(column)
    {
        _column = column;
        ClassName = column.StyleName;
    }
}

/// <summary>
/// Rtf rendering element for <see cref="Table"/> instances
/// </summary>
public class TableRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Table _table;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TableRtfTextRendererElement(Table table) : base(table)
    {
        _table = table;
        ClassName = table.StyleName;
    }
}