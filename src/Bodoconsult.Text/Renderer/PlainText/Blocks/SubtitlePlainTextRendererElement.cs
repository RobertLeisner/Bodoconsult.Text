using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Subtitle"/> instances
/// </summary>
public class SubtitlePlainTextRendererElement : ITextRendererElement
{
    private readonly Subtitle _Subtitle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public SubtitlePlainTextRendererElement(Subtitle Subtitle)
    {
        _Subtitle = Subtitle;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Subtitle.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}