using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html.Styles;

/// <summary>
/// HTML rendering element for <see cref="CodeStyle"/> instances
/// </summary>
public class CodeStyleHtmlTextRendererElement : HtmlParagraphStyleTextRendererElementBase
{
    private readonly CodeStyle _codeStyle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CodeStyleHtmlTextRendererElement(CodeStyle codeStyle) : base(codeStyle)
    {
        _codeStyle = codeStyle;
        ClassName = "CodeStyle";
    }
}