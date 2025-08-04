using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="ParagraphRight"/> instances
/// </summary>
public class ParagraphRightPlainTextRendererElement : ITextRendererElement
{
    private readonly ParagraphRight _ParagraphRight;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ParagraphRightPlainTextRendererElement(ParagraphRight ParagraphRight)
    {
        _ParagraphRight = ParagraphRight;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _ParagraphRight.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}