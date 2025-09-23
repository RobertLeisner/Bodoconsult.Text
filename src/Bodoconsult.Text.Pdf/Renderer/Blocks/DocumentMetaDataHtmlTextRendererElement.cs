// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Text;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Interfaces;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="DocumentMetaData"/> instances
/// </summary>
public class DocumentMetaDataPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly DocumentMetaData _documentMetaData;

    /// <summary>
    /// Default ctor
    /// </summary>
    public DocumentMetaDataPdfTextRendererElement(DocumentMetaData documentMetaData) : base(documentMetaData)
    {
        _documentMetaData = documentMetaData;
        ClassName = documentMetaData.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRenderer renderer)
    {
        var sb = new StringBuilder();
        if (!string.IsNullOrEmpty(_documentMetaData.Title))
        {
            sb.AppendLine($"<title>{_documentMetaData.Title}</title>");
        }

        if (!string.IsNullOrEmpty(_documentMetaData.Description))
        {
            sb.AppendLine($"<meta name=\"description\" content=\"{_documentMetaData.Description}\">");
        }

        if (!string.IsNullOrEmpty( _documentMetaData.Keywords))
        {
            sb.AppendLine($"<meta name=\"keywords\" content=\"{_documentMetaData.Keywords}\">");
        }

        if (!string.IsNullOrEmpty(_documentMetaData.Authors))
        {
            sb.AppendLine($"<meta name=\"author\" content=\"{_documentMetaData.Authors}\">");
        }

        renderer.Content.Append(sb);
    }
}