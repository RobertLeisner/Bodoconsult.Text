using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc3"/> instances
/// </summary>
public class Toc3PlainTextRendererElement : ITextRendererElement
{
    private readonly Toc3 _Toc3;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc3PlainTextRendererElement(Toc3 Toc3)
    {
        _Toc3 = Toc3;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Toc3.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}