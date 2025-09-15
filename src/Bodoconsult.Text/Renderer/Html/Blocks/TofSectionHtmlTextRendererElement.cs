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
        if (_tofSection.ChildBlocks.Count == 0)
        {
            return;
        }

        // Get the content of all inlines as string
        var sb = new StringBuilder();

        renderer.Content.AppendLine($"<p class=\"TofHeadingStyle\">{renderer.CheckContent(renderer.Document.DocumentMetaData.TofHeading)}</p>");

        DocumentRendererHelper.RenderBlockChildsToHtml(renderer, sb, _tofSection.ChildBlocks);

        // DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _tofSection.ChildInlines, string.Empty, true);
        renderer.Content.Append(sb);
    }
}