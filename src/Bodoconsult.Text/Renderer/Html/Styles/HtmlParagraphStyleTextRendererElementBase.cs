// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Extensions;
using Bodoconsult.Text.Helpers;
using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Bodoconsult.Text.Renderer.Html.Styles;

/// <summary>
/// Base class for <see cref="ParagraphStyleBase"/> based styles
/// </summary>
public class HtmlParagraphStyleTextRendererElementBase: ITextRendererElement
{
    /// <summary>
    /// HTML tag to use for rendering
    /// </summary>
    protected string TagToUse = "p";

    /// <summary>
    /// Current block to renderer
    /// </summary>
    public ParagraphStyleBase Style { get; private set; }
    /// <summary>
    /// CSS class name
    /// </summary>
    public string ClassName { get; protected set; }

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="style">Current paragraph style</param>
    public HtmlParagraphStyleTextRendererElementBase(ParagraphStyleBase style)
    {
        Style = style;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public virtual void RenderIt(ITextDocumentRender renderer)
    {
        var sb = new StringBuilder();

        sb.AppendLine($".{Style.GetType().Name}");
        sb.AppendLine("{");
        sb.AppendLine($"     font-family: \"{Style.FontName}\";");
        sb.AppendLine($"     font-size: {Style.FontSize}pt;");
        sb.AppendLine($"     margin: {Style.Margins.Top}pt {Style.Margins.Right}pt {Style.Margins.Bottom}pt {Style.Margins.Left}pt;");
        sb.AppendLine($"     padding: {Style.Paddings.Top}pt {Style.Paddings.Right}pt {Style.Paddings.Bottom}pt {Style.Paddings.Left}pt;");
        sb.AppendLine($"     border-width: {Style.BorderThickness.Top}pt {Style.BorderThickness.Right}pt {Style.BorderThickness.Bottom}pt {Style.BorderThickness.Left}pt;");
        sb.AppendLine($"     border-color: {Style.BorderBrush?.Color.ToHtml() ?? "#000000"};");
        sb.AppendLine($"     border-style: solid;");
        sb.AppendLine($"     text-align: {Style.TextAlignment.ToString().ToLowerInvariant()};");

        sb.AppendLine("}");
        renderer.Content.Append(sb);
    }

}