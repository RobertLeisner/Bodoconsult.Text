using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Info"/> instances
/// </summary>
public class InfoPlainTextRendererElement : ITextRendererElement
{
    private readonly Info _Info;

    /// <summary>
    /// Default ctor
    /// </summary>
    public InfoPlainTextRendererElement(Info Info)
    {
        _Info = Info;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Info.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}