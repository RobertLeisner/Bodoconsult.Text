using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="ParagraphCenter"/> instances
/// </summary>
public class ParagraphCenterPlainTextRendererElement : ITextRendererElement
{
    private readonly ParagraphCenter _ParagraphCenter;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ParagraphCenterPlainTextRendererElement(ParagraphCenter ParagraphCenter)
    {
        _ParagraphCenter = ParagraphCenter;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _ParagraphCenter.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}