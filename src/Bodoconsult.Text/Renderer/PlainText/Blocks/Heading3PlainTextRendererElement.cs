using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Heading3"/> instances
/// </summary>
public class Heading3PlainTextRendererElement : ITextRendererElement
{
    private readonly Heading3 _Heading3;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Heading3PlainTextRendererElement(Heading3 Heading3)
    {
        _Heading3 = Heading3;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Heading3.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}