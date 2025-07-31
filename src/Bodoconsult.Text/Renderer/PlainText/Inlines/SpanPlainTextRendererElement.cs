// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.


// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.PlainText;


/// <summary>
/// Render a <see cref="Span"/> element
/// </summary>
public class SpanPlainTextRendererElement : ITextRendererElement
{
    private readonly Span _span;

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="span">Paragraph</param>
    public SpanPlainTextRendererElement(Span span)
    {
        _span = span;
    }

    /// <summary>
    /// Render the elememt
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRender renderer)
    {
        //if (_span.ChildInlines.Count == 0)
        //{
            renderer.Content.Append($"{renderer.CheckContent(_span.Content)}");
        //}
        //else
        //{
        //    DocumentRendererHelper.RenderInlineChilds(renderer, _span.ChildInlines);
        //}
    }
}