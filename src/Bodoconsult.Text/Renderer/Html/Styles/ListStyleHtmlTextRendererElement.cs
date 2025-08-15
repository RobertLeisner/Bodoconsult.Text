using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html.Styles;

/// <summary>
/// HTML rendering element for <see cref="ListStyle"/> instances
/// </summary>
public class ListStyleHtmlTextRendererElement : HtmlParagraphStyleTextRendererElementBase
{
    private readonly ListStyle _listStyle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListStyleHtmlTextRendererElement(ListStyle listStyle) : base(listStyle)
    {
        _listStyle = listStyle;
        ClassName = "ListStyle";
    }
}