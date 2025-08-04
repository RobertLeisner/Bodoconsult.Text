using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc1"/> instances
/// </summary>
public class Toc1PlainTextRendererElement : ITextRendererElement
{
    private readonly Toc1 _Toc1;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc1PlainTextRendererElement(Toc1 Toc1)
    {
        _Toc1 = Toc1;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Toc1.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}