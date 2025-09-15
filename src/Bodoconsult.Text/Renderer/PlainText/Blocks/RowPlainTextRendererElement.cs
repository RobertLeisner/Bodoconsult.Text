// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using Bodoconsult.Text.Renderer.Html;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// HTML rendering element for <see cref="Row"/> instances
/// </summary>
public class RowPlainTextRendererElement : ITextRendererElement
{
    private readonly Row _row;

    /// <summary>
    /// Default ctor
    /// </summary>
    public RowPlainTextRendererElement(Row row) 
    {
        _row = row;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        //if (string.IsNullOrEmpty(LocalCss))
        //{
        //    renderer.Content.AppendLine($"<{TagToUse} class=\"{ClassName}\">");
        //}
        //else
        //{
        //    renderer.Content.AppendLine($"<{TagToUse} class=\"{ClassName}\" style=\"{LocalCss}\">");
        //}



        //DocumentRendererHelper.RenderCellsToHtml(renderer, _row.Cells);

        //renderer.Content.Append($"</{TagToUse}>{Environment.NewLine}");
    }
}