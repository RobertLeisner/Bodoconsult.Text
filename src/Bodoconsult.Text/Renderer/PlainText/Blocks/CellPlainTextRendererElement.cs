// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Renderer.Html;
using Bodoconsult.Text.Renderer.Rtf.Blocks;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// HTML rendering element for <see cref="Cell"/> instances
/// </summary>
public class CellPlainTextRendererElement : ITextRendererElement
{
    private readonly Cell _cell;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CellPlainTextRendererElement(Cell cell)
    {
        _cell = cell;
    }

    private string GetClassName(Cell cell)
    {
        // ToDo: Other alignments
        return "CellLeftStyle";
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        throw new System.NotImplementedException();
    }
}
