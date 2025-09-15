// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Renderer.Html;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// HTML rendering element for <see cref="Column"/> instances
/// </summary>
public class ColumnPlainTextRendererElement : ITextRendererElement
{
    private readonly Column _column;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ColumnPlainTextRendererElement(Column column) 
    {
        _column = column;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        // Do nothing
    }
}