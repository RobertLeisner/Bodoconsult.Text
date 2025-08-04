using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc2"/> instances
/// </summary>
public class Toc2PlainTextRendererElement : ITextRendererElement
{
    private readonly Toc2 _Toc2;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc2PlainTextRendererElement(Toc2 Toc2)
    {
        _Toc2 = Toc2;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Toc2.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}