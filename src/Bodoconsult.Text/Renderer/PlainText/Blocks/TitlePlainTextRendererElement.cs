using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Title"/> instances
/// </summary>
public class TitlePlainTextRendererElement : ITextRendererElement
{
    private readonly Title _Title;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TitlePlainTextRendererElement(Title Title)
    {
        _Title = Title;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Title.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}