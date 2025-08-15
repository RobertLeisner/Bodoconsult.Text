// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="Figure"/> instances
/// </summary>
public class FigureHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly Figure _figure;

    /// <summary>
    /// Default ctor
    /// </summary>
    public FigureHtmlTextRendererElement(Figure figure) : base(figure)
    {
        _figure = figure;
        ClassName = figure.StyleName;
    }
}