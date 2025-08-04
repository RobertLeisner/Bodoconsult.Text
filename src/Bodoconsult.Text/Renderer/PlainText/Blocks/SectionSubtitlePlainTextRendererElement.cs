using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="SectionSubtitle"/> instances
/// </summary>
public class SectionSubtitlePlainTextRendererElement : ITextRendererElement
{
    private readonly SectionSubtitle _SectionSubtitle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionSubtitlePlainTextRendererElement(SectionSubtitle SectionSubtitle)
    {
        _SectionSubtitle = SectionSubtitle;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _SectionSubtitle.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}