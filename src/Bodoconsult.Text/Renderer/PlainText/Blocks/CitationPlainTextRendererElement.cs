using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Citation"/> instances
/// </summary>
public class CitationPlainTextRendererElement : ITextRendererElement
{
    private readonly Citation _Citation;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CitationPlainTextRendererElement(Citation Citation)
    {
        _Citation = Citation;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Citation.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}