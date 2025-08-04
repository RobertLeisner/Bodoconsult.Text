using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Figure"/> instances
/// </summary>
public class FigurePlainTextRendererElement : ITextRendererElement
{
    private readonly Figure _Figure;

    /// <summary>
    /// Default ctor
    /// </summary>
    public FigurePlainTextRendererElement(Figure Figure)
    {
        _Figure = Figure;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Figure.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}