// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="DocumentMetaData"/> instances
/// </summary>
public class DocumentMetaDataRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly DocumentMetaData _documentMetaData;

    /// <summary>
    /// Default ctor
    /// </summary>
    public DocumentMetaDataRtfTextRendererElement(DocumentMetaData documentMetaData) : base(documentMetaData)
    {
        _documentMetaData = documentMetaData;
        ClassName = documentMetaData.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        var sb = new StringBuilder();

        

        FontsParsing(renderer.Styleset, sb);
        ColorParsing(renderer.Styleset, sb);


        sb.AppendLine("{\\info ");

        var date = DateTime.Now;
        sb.AppendLine($"{{\\creatim\\yr{date.Year}\\mo{date.Month}\\dy{date.Day}\\hr{date.Hour}\\min{date.Minute}}}");
        sb.AppendLine("{\\edmins0}");
        sb.AppendLine("{\\nofpages1}");
        sb.AppendLine("{\\nofwords0}");
        sb.AppendLine("{\\nofchars0}");

        if (!string.IsNullOrEmpty(_documentMetaData.Title))
        {
            sb.AppendLine($"{{\\title {_documentMetaData.Title}}}");
        }

        if (!string.IsNullOrEmpty(_documentMetaData.Description))
        {
            sb.AppendLine($"{{\\comment {_documentMetaData.Description}}}");
        }

        if (!string.IsNullOrEmpty( _documentMetaData.Keywords))
        {
            sb.AppendLine($"{{\\keywords {_documentMetaData.Keywords}}}");
        }

        if (!string.IsNullOrEmpty(_documentMetaData.Authors))
        {
            sb.AppendLine($"{{\\author {_documentMetaData.Authors}}}");
        }

        if (!string.IsNullOrEmpty(_documentMetaData.Company))
        {
            sb.AppendLine($"{{\\company {_documentMetaData.Company}}}");
        }

        sb.AppendLine("}");


        // Basic page settings
        var style = (DocumentStyle)renderer.Styleset.FindStyle("DocumentStyle");

        sb.AppendLine(style.PageHeight < style.PageWidth ? "\\landscape" : "\\portrait");

        sb.AppendLine(
            $"\\paperw{MeasurementHelper.GetTwipsFromCm((float)style.PageWidth)}\\paperh{MeasurementHelper.GetTwipsFromCm((float)style.PageHeight)}\\margl{MeasurementHelper.GetTwipsFromCm((float)style.MarginLeft)}\\margr{MeasurementHelper.GetTwipsFromCm((float)style.MarginRight)}\\margt{MeasurementHelper.GetTwipsFromCm((float)style.MarginTop)}\\margb{MeasurementHelper.GetTwipsFromCm((float)style.MarginBottom)} ");


        // Now add all to content
        renderer.Content.Append(sb);
    }

    private void ColorParsing(Styleset styleset, StringBuilder sb)
    {

    }

    private void FontsParsing(Styleset styleset, StringBuilder sb)
    {
        var fonts = new List<string>();

        var baseType = typeof(ParagraphStyleBase);

        foreach (var style in styleset.StyleDictionary.Values.Where(x => baseType.IsAssignableFrom(x.GetType())))
        {
            if (style is not ParagraphStyleBase paragraphStyle)
            {
                continue;
            }

            if (fonts.Exists(x => x == paragraphStyle.FontName))
            {
                continue;
            }

            fonts.Add(paragraphStyle.FontName);
        }

        sb.AppendLine("{\\fonttbl");

        for (var i = 0; i < fonts.Count; i++)
        {
            sb.AppendLine($"{{\\f{i} {fonts[i]};}}");
        }

        sb.AppendLine("}");
    }
}