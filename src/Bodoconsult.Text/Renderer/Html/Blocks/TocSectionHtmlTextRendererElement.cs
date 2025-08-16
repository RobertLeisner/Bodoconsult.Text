using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="TocSection"/> instances
/// </summary>
public class TocSectionHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly TocSection _tocSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TocSectionHtmlTextRendererElement(TocSection tocSection) : base(tocSection)
    {
        _tocSection = tocSection;
        ClassName = tocSection.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();

        DocumentRendererHelper.RenderInlineBlocksToPlain(renderer, sb, _tocSection.ChildBlocks, string.Empty, true);

        // DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _tocSection.ChildInlines, string.Empty, true);
        renderer.Content.Append(sb);
    }
}