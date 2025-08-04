using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Code"/> instances
/// </summary>
public class CodePlainTextRendererElement : ITextRendererElement
{
    private readonly Code _Code;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CodePlainTextRendererElement(Code Code)
    {
        _Code = Code;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _Code.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}