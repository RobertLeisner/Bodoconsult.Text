using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Heading5"/> instances
/// </summary>
public class Heading5PlainTextRendererElement : ITextRendererElement
{
    private readonly Heading5 _Heading5;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Heading5PlainTextRendererElement(Heading5 Heading5)
    {
        _Heading5 = Heading5;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Heading5.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}