using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html.Styles;

/// <summary>
/// HTML rendering element for <see cref="DocumentStyle"/> instances
/// </summary>
public class DocumentStyleHtmlTextRendererElement : HtmlPageStyleTextRendererElementBase
{
    private readonly PageStyleBase _documentStyle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public DocumentStyleHtmlTextRendererElement(DocumentStyle documentStyle) : base(documentStyle)
    {
        _documentStyle = documentStyle;
        ClassName = "DocumentStyle";
    }
}