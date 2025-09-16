// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Text;

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

    /// <summary>
    /// Render cell to RTF string
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderToString(ITextDocumentRender renderer)
    {
        ParagraphStyleBase style;

        var type = _cell.Column.DataType;

        // Right aligned
        if (type == typeof(double) || type == typeof(float) ||
            type == typeof(short) || type == typeof(int) ||
            type == typeof(long) || type == typeof(Int128) ||
            type == typeof(byte))
        {
            style = (ParagraphStyleBase)renderer.Styleset.FindStyle("CellRightStyle");
        }
        else
        // Centered aligned
        if (type == typeof(bool) || type == typeof(DateTime))
        {
            style = (ParagraphStyleBase)renderer.Styleset.FindStyle("CellCenterStyle");
        }

        // Default: left aligned
        else
        {
            style = (ParagraphStyleBase)renderer.Styleset.FindStyle("CellLeftStyle");
        }

        renderer.Content.Append("\\intbl\\pard\\plain");
        renderer.Content.Append(RtfHelper.GetFormatSettings(style, renderer.Styleset, true));

        var sb = new StringBuilder();

        DocumentRendererHelper.RenderInlineChildsToRtf(renderer, sb, _cell.ChildInlines);


        renderer.Content.Append($"{{{sb}}}\\cell ");
    }
}