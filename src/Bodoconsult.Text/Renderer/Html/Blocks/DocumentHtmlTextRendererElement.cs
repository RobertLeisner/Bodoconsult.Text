using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="Document"/> instances
/// </summary>
public class DocumentHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly Document _document;

    /// <summary>
    /// Default ctor
    /// </summary>
    public DocumentHtmlTextRendererElement(Document document) : base(document)
    {
        _document = document;
        ClassName = document.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        renderer.Content.AppendLine("<!DOCTYPE html>");
        renderer.Content.AppendLine("<html>");
        renderer.Content.AppendLine("<head>");
        renderer.Content.AppendLine("<meta charset=\"utf-8\">");

        var sb = new StringBuilder();
        DocumentRendererHelper.RenderBlockChildsToPlain(renderer, sb, _document.ChildBlocks);
        renderer.Content.Append(sb);

        renderer.Content.AppendLine("</body>");
        renderer.Content.AppendLine("</html>");

    }
}