// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html
{
    /// <summary>
    /// <see cref="ITextRendererElementFactory"/> implementation for HTML text rendering
    /// </summary>
    public class HtmlTextRendererElementFactory : ITextRendererElementFactory
    {

        /// <summary>
        /// Create an instance of an <see cref="ITextRendererElement"/> for a given <see cref="TextElement"/>
        /// </summary>
        /// <param name="textElement">Given text element</param>
        /// <returns>Instance of an <see cref="ITextRendererElement"/></returns>
        public ITextRendererElement CreateInstance(TextElement textElement)
        {

            // ParagraphBase based elements

            if (textElement is Citation citation)
            {
                return new CitationHtmlTextRendererElement(citation);
            }

            if (textElement is Code code)
            {
                return new CodeHtmlTextRendererElement(code);
            }

            if (textElement is Equation equation)
            {
                return new EquationHtmlTextRendererElement(equation);
            }

            if (textElement is Error error)
            {
                return new ErrorHtmlTextRendererElement(error);
            }

            if (textElement is Figure figure)
            {
                return new FigureHtmlTextRendererElement(figure);
            }

            if (textElement is Heading1 heading1)
            {
                return new Heading1HtmlTextRendererElement(heading1);
            }

            if (textElement is Heading2 heading2)
            {
                return new Heading2HtmlTextRendererElement(heading2);
            }

            if (textElement is Heading3 heading3)
            {
                return new Heading3HtmlTextRendererElement(heading3);
            }

            if (textElement is Heading4 heading4)
            {
                return new Heading4HtmlTextRendererElement(heading4);
            }

            if (textElement is Heading5 heading5)
            {
                return new Heading5HtmlTextRendererElement(heading5);
            }

            if (textElement is Image image)
            {
                return new ImageHtmlTextRendererElement(image);
            }

            if (textElement is Info info)
            {
                return new InfoHtmlTextRendererElement(info);
            }

            if (textElement is List list)
            {
                return new ListHtmlTextRendererElement(list);
            }

            if (textElement is ListItem listItem)
            {
                return new ListItemHtmlTextRendererElement(listItem);
            }

            if (textElement is Paragraph paragraph)
            {
                return new ParagraphHtmlTextRendererElement(paragraph);
            }

            if (textElement is ParagraphCenter paragraphCenter)
            {
                return new ParagraphCenterHtmlTextRendererElement(paragraphCenter);
            }

            if (textElement is ParagraphJustify paragraphJustify)
            {
                return new ParagraphJustifyHtmlTextRendererElement(paragraphJustify);
            }

            if (textElement is ParagraphRight paragraphRight)
            {
                return new ParagraphRightHtmlTextRendererElement(paragraphRight);
            }

            if (textElement is SectionSubtitle sectionSubtitle)
            {
                return new SectionSubtitleHtmlTextRendererElement(sectionSubtitle);
            }

            if (textElement is SectionTitle sectionTitle)
            {
                return new SectionTitleHtmlTextRendererElement(sectionTitle);
            }

            if (textElement is Subtitle subtitle)
            {
                return new SubtitleHtmlTextRendererElement(subtitle);
            }

            if (textElement is Title title)
            {
                return new TitleHtmlTextRendererElement(title);
            }

            if (textElement is Toc1 toc1)
            {
                return new Toc1HtmlTextRendererElement(toc1);
            }

            if (textElement is Toc2 toc2)
            {
                return new Toc2HtmlTextRendererElement(toc2);
            }

            if (textElement is Toc3 toc3)
            {
                return new Toc3HtmlTextRendererElement(toc3);
            }

            if (textElement is Toc4 toc4)
            {
                return new Toc4HtmlTextRendererElement(toc4);
            }

            if (textElement is Toc5 toc5)
            {
                return new Toc5HtmlTextRendererElement(toc5);
            }

            if (textElement is Warning warning)
            {
                return new WarningHtmlTextRendererElement(warning);
            }

            // ToDo: add all others

            // Inline based elements
            if (textElement is Span span)
            {
                return new SpanHtmlTextRendererElement(span);
            }

            if (textElement is Bold bold)
            {
                return new BoldHtmlTextRendererElement(bold);
            }

            if (textElement is Italic italic)
            {
                return new ItalicHtmlTextRendererElement(italic);
            }

            if (textElement is LineBreak lineBreak)
            {
                return new LineBreakHtmlTextRendererElement(lineBreak);
            }

            if (textElement is Hyperlink hyperlink)
            {
                return new HyperlinkHtmlTextRendererElement(hyperlink);
            }

            return null;
        }

    }
}
