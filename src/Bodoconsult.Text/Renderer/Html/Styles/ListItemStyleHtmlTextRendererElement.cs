using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html.Styles;

/// <summary>
/// HTML rendering element for <see cref="ListItemStyle"/> instances
/// </summary>
public class ListItemStyleHtmlTextRendererElement : HtmlParagraphStyleTextRendererElementBase
{
    private readonly ListItemStyle _listItemStyle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListItemStyleHtmlTextRendererElement(ListItemStyle listItemStyle) : base(listItemStyle)
    {
        _listItemStyle = listItemStyle;
        ClassName = "ListItemStyle";
    }
}