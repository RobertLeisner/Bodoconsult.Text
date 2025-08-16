using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="ToeSection"/> instances
/// </summary>
public class ToeSectionHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly ToeSection _toeSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ToeSectionHtmlTextRendererElement(ToeSection toeSection) : base(toeSection)
    {
        _toeSection = toeSection;
        ClassName = toeSection.StyleName;
    }
    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();

        DocumentRendererHelper.RenderInlineBlocksToPlain(renderer, sb, _toeSection.ChildBlocks, string.Empty, true);

        // DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _toeSection.ChildInlines, string.Empty, true);
        renderer.Content.Append(sb);
    }
}