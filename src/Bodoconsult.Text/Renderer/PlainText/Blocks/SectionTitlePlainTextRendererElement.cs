using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="SectionTitle"/> instances
/// </summary>
public class SectionTitlePlainTextRendererElement : ITextRendererElement
{
    private readonly SectionTitle _SectionTitle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionTitlePlainTextRendererElement(SectionTitle SectionTitle)
    {
        _SectionTitle = SectionTitle;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _SectionTitle.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}