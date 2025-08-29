// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Text;

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

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();

        if (string.IsNullOrEmpty(LocalCss))
        {
            renderer.Content.Append($"<{TagToUse} class=\"{ClassName}\">");
        }
        else
        {
            renderer.Content.Append($"<{TagToUse} class=\"{ClassName}\" style=\"{LocalCss}\">");
        }



        sb.Append(_figure.CurrentPrefix);

        DocumentRendererHelper.RenderInlineChildsToHtml(renderer, sb, Block.ChildInlines);

        // Get max height and with for images in twips
        StylesetHelper.GetMaxWidthAndHeight(renderer.Styleset, out var maxWidth, out var maxHeight);

        StylesetHelper.GetWidthAndHeight(MeasurementHelper.GetTwipsFromPx(_figure.OriginalWidth), MeasurementHelper.GetTwipsFromPx(_figure.OriginalHeight), maxWidth, maxHeight, out var width, out var height);

        renderer.Content.Append($"<img src=\"{_figure.Uri}\" alt=\"{sb}\" width=\"{MeasurementHelper.GetPxFromTwips(width)}px\" height=\"{MeasurementHelper.GetPxFromTwips(height)}px\"/><br>");

        renderer.Content.Append(sb);
        renderer.Content.Append($"</{TagToUse}>{Environment.NewLine}");
    }
}