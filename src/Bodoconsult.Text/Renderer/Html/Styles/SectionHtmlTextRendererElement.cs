using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;

namespace Bodoconsult.Text.Renderer.Html.Styles;

/// <summary>
/// HTML rendering element for <see cref="Section"/> instances
/// </summary>
public class SectionHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly Section _section;

    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionHtmlTextRendererElement(Section section) : base(section)
    {
        _section = section;
        ClassName = section.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();

        DocumentRendererHelper.RenderBlockChildsToPlain(renderer, sb, _section.ChildBlocks);

        // DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _section.ChildInlines, string.Empty, true);
        renderer.Content.Append(sb);
    }
}