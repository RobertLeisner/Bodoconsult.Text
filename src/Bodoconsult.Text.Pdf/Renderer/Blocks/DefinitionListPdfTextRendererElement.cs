using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Pdf.Renderer.Blocks;

/// <summary>
/// HTML rendering element for <see cref="DefinitionList"/> instances
/// </summary>
public class DefinitionListPdfTextRendererElement : PdfTextRendererElementBase
{
    private readonly DefinitionList _item;

    /// <summary>
    /// Default ctor
    /// </summary>
    public DefinitionListPdfTextRendererElement(DefinitionList item) : base(item)
    {
        _item = item;
        ClassName = item.StyleName;
    }
}