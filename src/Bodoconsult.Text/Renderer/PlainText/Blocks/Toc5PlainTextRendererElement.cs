using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc5"/> instances
/// </summary>
public class Toc5PlainTextRendererElement : ITextRendererElement
{
    private readonly Toc5 _Toc5;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc5PlainTextRendererElement(Toc5 Toc5)
    {
        _Toc5 = Toc5;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Toc5.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}