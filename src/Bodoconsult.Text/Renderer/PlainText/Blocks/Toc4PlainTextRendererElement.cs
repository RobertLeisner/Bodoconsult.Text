using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Toc4"/> instances
/// </summary>
public class Toc4PlainTextRendererElement : ITextRendererElement
{
    private readonly Toc4 _Toc4;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc4PlainTextRendererElement(Toc4 Toc4)
    {
        _Toc4 = Toc4;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Toc4.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}