// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="TocBase"/> instances
/// </summary>
public class TocBaseHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly TocBase _tocBase;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TocBaseHtmlTextRendererElement(TocBase tocBase) : base(tocBase)
    {
        _tocBase = tocBase;
        ClassName = tocBase.StyleName;
    }
}