using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="TofSection"/> instances
/// </summary>
public class TofSectionHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly TofSection _tofSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TofSectionHtmlTextRendererElement(TofSection tofSection) : base(tofSection)
    {
        _tofSection = tofSection;
        ClassName = tofSection.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();

        DocumentRendererHelper.RenderBlockChildsToPlain(renderer, sb, _tofSection.ChildBlocks);

        // DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _tofSection.ChildInlines, string.Empty, true);
        renderer.Content.Append(sb);
    }
}