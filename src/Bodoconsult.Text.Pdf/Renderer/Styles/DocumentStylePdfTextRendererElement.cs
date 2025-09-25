using System.Text;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Interfaces;

namespace Bodoconsult.Text.Pdf.Renderer.Styles;

/// <summary>
/// HTML rendering element for <see cref="DocumentStyle"/> instances
/// </summary>
public class DocumentStylePdfTextRendererElement : PdfPageStyleTextRendererElementBase
{
    private readonly PageStyleBase _documentStyle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public DocumentStylePdfTextRendererElement(DocumentStyle documentStyle) : base(documentStyle)
    {
        _documentStyle = documentStyle;
        ClassName = "DocumentStyle";
    }
}