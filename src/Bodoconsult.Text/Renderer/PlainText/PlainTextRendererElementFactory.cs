// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.PlainText
{
    public class PlainTextRendererElementFactory : ITextRendererElementFactory
    {

        public ITextRendererElement CreateInstance(TextElement textElement)
        {
            if (textElement is Paragraph paragraph)
            {
                return new ParagraphPlainTextRendererElement(paragraph);
            }

            if (textElement is Heading1 heading1)
            {
                return new Heading1PlainTextRendererElement(heading1);
            }

            if (textElement is Heading2 heading2)
            {
                return new Heading2PlainTextRendererElement(heading2);
            }

            if (textElement is Span span)
            {
                return new SpanPlainTextRendererElement(span);
            }

            if (textElement is Bold bold)
            {
                return new BoldPlainTextRendererElement(bold);
            }

            if (textElement is Italic italic)
            {
                return new ItalicPlainTextRendererElement(italic);
            }

            if (textElement is LineBreak lineBreak)
            {
                return new LineBreakPlainTextRendererElement(lineBreak);
            }

            if (textElement is Hyperlink hyperlink)
            {
                return new HyperlinkPlainTextRendererElement(hyperlink);
            }

            return null;
        }

    }
}
