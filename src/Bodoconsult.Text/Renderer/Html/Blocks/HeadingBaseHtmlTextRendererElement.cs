// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="HeadingBase"/> instances
/// </summary>
public class HeadingBaseHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly HeadingBase _headingBase;

    /// <summary>
    /// Default ctor
    /// </summary>
    public HeadingBaseHtmlTextRendererElement(HeadingBase headingBase) : base(headingBase)
    {
        _headingBase = headingBase;
        ClassName = headingBase.StyleName;
    }
}