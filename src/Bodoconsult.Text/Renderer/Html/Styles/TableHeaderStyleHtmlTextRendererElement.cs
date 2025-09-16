// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html.Styles;

/// <summary>
/// HTML rendering element for <see cref="TableStyle"/> instances
/// </summary>
public class TableHeaderStyleHtmlTextRendererElement : HtmlParagraphStyleTextRendererElementBase
{
    private readonly TableHeaderStyle _tableHeaderStyle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TableHeaderStyleHtmlTextRendererElement(TableHeaderStyle tableHeaderStyle): base(tableHeaderStyle)
    {
        _tableHeaderStyle = tableHeaderStyle;
        ClassName = "TableHeaderStyle";
    }
}