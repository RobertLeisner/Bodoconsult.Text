using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Heading4"/> instances
/// </summary>
public class Heading4PlainTextRendererElement : ITextRendererElement
{
    private readonly Heading4 _Heading4;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Heading4PlainTextRendererElement(Heading4 Heading4)
    {
        _Heading4 = Heading4;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Heading4.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}