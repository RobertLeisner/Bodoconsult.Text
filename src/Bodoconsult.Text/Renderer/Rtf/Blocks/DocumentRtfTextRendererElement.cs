using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="Document"/> instances
/// </summary>
public class DocumentRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly Document _document;

    /// <summary>
    /// Default ctor
    /// </summary>
    public DocumentRtfTextRendererElement(Document document) : base(document)
    {
        _document = document;
        ClassName = document.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        renderer.Content.AppendLine("{\\rtf1\\ansi\\deff0");

        var sb = new StringBuilder();
        DocumentRendererHelper.RenderBlockChildsToPlain(renderer, sb, _document.ChildBlocks);
        renderer.Content.Append(sb);

        renderer.Content.AppendLine("}");

    }
}