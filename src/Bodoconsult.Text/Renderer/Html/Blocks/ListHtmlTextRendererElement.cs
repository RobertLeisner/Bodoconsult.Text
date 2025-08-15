// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="List"/> instances
/// </summary>
public class ListHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly List _list;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListHtmlTextRendererElement(List list) : base(list)
    {
        _list = list;
        ClassName = list.StyleName;
    }
}