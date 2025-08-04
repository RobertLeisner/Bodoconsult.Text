using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Warning"/> instances
/// </summary>
public class WarningPlainTextRendererElement : ITextRendererElement
{
    private readonly Warning _Warning;

    /// <summary>
    /// Default ctor
    /// </summary>
    public WarningPlainTextRendererElement(Warning Warning)
    {
        _Warning = Warning;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Warning.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}