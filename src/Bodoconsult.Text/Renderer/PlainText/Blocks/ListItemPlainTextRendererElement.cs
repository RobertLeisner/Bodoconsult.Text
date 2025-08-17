// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;
using Bodoconsult.Text.Extensions;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="ListItem"/> instances
/// </summary>
public class ListItemPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{

    private readonly ListItem _listItem;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListItemPlainTextRendererElement(ListItem listItem)
    {
        Paragraph = listItem;
        _listItem = listItem;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        // Get the content of all inlines as string
        var sb = new StringBuilder();

        var list = (List)_listItem.Parent;

        switch (list.ListStyleType)
        {
            case ListStyleTypeEnum.Disc:
                sb.Append('*');
                break;
            case ListStyleTypeEnum.Circle:
                sb.Append('o');
                break;
            case ListStyleTypeEnum.Square:
                sb.Append('-');
                break;
            case ListStyleTypeEnum.Decimal:
                list.Counter++;
                sb.Append(list.Counter);
                break;
            case ListStyleTypeEnum.DecimalLeadingZero:
                list.Counter++;
                sb.Append(list.Counter.ToString("00"));
                break;
            case ListStyleTypeEnum.UpperRoman:
                list.Counter++;
                sb.Append(list.Counter.ArabicToRoman().ToUpperInvariant());
                break;
            case ListStyleTypeEnum.LowerRoman:
                list.Counter++;
                sb.Append(list.Counter.ArabicToRoman().ToLowerInvariant());
                break;
            case ListStyleTypeEnum.UpperLatin:
                // ToDo: Get latin letter
                list.Counter++;
                sb.Append(list.Counter);
                break;
            case ListStyleTypeEnum.LowerLatin:
                // ToDo: Get latin letter
                list.Counter++;
                sb.Append(list.Counter);
                break;
            case ListStyleTypeEnum.Customized:
                sb.Append(list.ListStyleTypeChar);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        sb.Append(' ');

        DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, Paragraph.ChildInlines, string.Empty, false);

        // Now add the formatted text to the rendered content
        renderer.Content.AppendLine(sb.ToString());
    }
}