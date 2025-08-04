using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="ListItem"/> instances
/// </summary>
public class ListItemPlainTextRendererElement : ITextRendererElement
{
    private readonly ListItem _ListItem;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListItemPlainTextRendererElement(ListItem ListItem)
    {
        _ListItem = ListItem;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    public void RenderIt(ITextDocumentRender renderer)
    {
        DocumentRendererHelper.RenderInlineChilds(renderer, _ListItem.ChildInlines, string.Empty, true);
        renderer.Content.Append($"{Environment.NewLine}");
    }
}