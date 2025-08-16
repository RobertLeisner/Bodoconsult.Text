// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Renderer.Html.Styles;
using Bodoconsult.Text.Renderer.PlainText;

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
        public ITextRendererElement CreateInstance(DocumentElement textElement)
        {
            // Base elements
            if (textElement is Document document)
            {
                return new DocumentHtmlTextRendererElement(document);
            }

            if (textElement is DocumentMetaData documentMetaData)
            {
                return new DocumentMetaDataHtmlTextRendererElement(documentMetaData);
            }

            if (textElement is Styleset styleset)
            {
                return new StylesetHtmlTextRendererElement(styleset);
            }

            if (textElement is Section section)
            {
                return new SectionHtmlTextRendererElement(section);
            }

            if (textElement is TocSection tocSection)
            {
                return new TocSectionHtmlTextRendererElement(tocSection);
            }

            if (textElement is ToeSection toeSection)
            {
                return new ToeSectionHtmlTextRendererElement(toeSection);
            }

            if (textElement is TofSection tofSection)
            {
                return new TofSectionHtmlTextRendererElement(tofSection);
            }

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

            // Base styles
            if (textElement is DocumentStyle documentStyle)
            {
                return new DocumentStyleHtmlTextRendererElement(documentStyle);
            }

            if (textElement is SectionStyle sectionStyle)
            {
                return new SectionStyleHtmlTextRendererElement(sectionStyle);
            }

            if (textElement is TocSectionStyle tocSectionStyle)
            {
                return new TocSectionStyleHtmlTextRendererElement(tocSectionStyle);
            }

            if (textElement is ToeSectionStyle toeSectionStyle)
            {
                return new ToeSectionStyleHtmlTextRendererElement(toeSectionStyle);
            }

            if (textElement is TofSectionStyle tofSectionStyle)
            {
                return new TofSectionStyleHtmlTextRendererElement(tofSectionStyle);
            }

            // Paragraph style based
            if (textElement is CitationStyle citationStyle)
            {
                return new CitationStyleHtmlTextRendererElement(citationStyle);
            }

            if (textElement is CodeStyle codeStyle)
            {
                return new CodeStyleHtmlTextRendererElement(codeStyle);
            }

            if (textElement is EquationStyle equationStyle)
            {
                return new EquationStyleHtmlTextRendererElement(equationStyle);
            }

            if (textElement is ErrorStyle errorStyle)
            {
                return new ErrorStyleHtmlTextRendererElement(errorStyle);
            }

            if (textElement is FigureStyle figureStyle)
            {
                return new FigureStyleHtmlTextRendererElement(figureStyle);
            }

            if (textElement is Heading1Style heading1Style)
            {
                return new Heading1StyleHtmlTextRendererElement(heading1Style);
            }

            if (textElement is Heading2Style heading2Style)
            {
                return new Heading2StyleHtmlTextRendererElement(heading2Style);
            }

            if (textElement is Heading3Style heading3Style)
            {
                return new Heading3StyleHtmlTextRendererElement(heading3Style);
            }

            if (textElement is Heading4Style heading4Style)
            {
                return new Heading4StyleHtmlTextRendererElement(heading4Style);
            }

            if (textElement is Heading5Style heading5Style)
            {
                return new Heading5StyleHtmlTextRendererElement(heading5Style);
            }

            if (textElement is ImageStyle imageStyle)
            {
                return new ImageStyleHtmlTextRendererElement(imageStyle);
            }

            if (textElement is InfoStyle infoStyle)
            {
                return new InfoStyleHtmlTextRendererElement(infoStyle);
            }

            if (textElement is ListItemStyle listItemStyle)
            {
                return new ListItemStyleHtmlTextRendererElement(listItemStyle);
            }

            if (textElement is ListStyle listStyle)
            {
                return new ListStyleHtmlTextRendererElement(listStyle);
            }

            if (textElement is ParagraphCenterStyle paragraphCenterStyle)
            {
                return new ParagraphCenterStyleHtmlTextRendererElement(paragraphCenterStyle);
            }

            if (textElement is ParagraphJustifyStyle paragraphJustifyStyle)
            {
                return new ParagraphJustifyStyleHtmlTextRendererElement(paragraphJustifyStyle);
            }

            if (textElement is ParagraphRightStyle paragraphRightStyle)
            {
                return new ParagraphRightStyleHtmlTextRendererElement(paragraphRightStyle);
            }

            if (textElement is ParagraphStyle paragraphStyle)
            {
                return new ParagraphStyleHtmlTextRendererElement(paragraphStyle);
            }

            if (textElement is SectionSubtitleStyle sectionSubtitleStyle)
            {
                return new SectionSubtitleStyleHtmlTextRendererElement(sectionSubtitleStyle);
            }

            if (textElement is SectionTitleStyle sectionTitleStyle)
            {
                return new SectionTitleStyleHtmlTextRendererElement(sectionTitleStyle);
            }

            if (textElement is SubtitleStyle subtitleStyle)
            {
                return new SubtitleStyleHtmlTextRendererElement(subtitleStyle);
            }

            if (textElement is TitleStyle titleStyle)
            {
                return new TitleStyleHtmlTextRendererElement(titleStyle);
            }

            if (textElement is Toc1Style toc1Style)
            {
                return new Toc1StyleHtmlTextRendererElement(toc1Style);
            }

            if (textElement is Toc2Style toc2Style)
            {
                return new Toc2StyleHtmlTextRendererElement(toc2Style);
            }

            if (textElement is Toc3Style toc3Style)
            {
                return new Toc3StyleHtmlTextRendererElement(toc3Style);
            }

            if (textElement is Toc4Style toc4Style)
            {
                return new Toc4StyleHtmlTextRendererElement(toc4Style);
            }

            if (textElement is Toc5Style toc5Style)
            {
                return new Toc5StyleHtmlTextRendererElement(toc5Style);
            }

            if (textElement is WarningStyle warningStyle)
            {
                return new WarningStyleHtmlTextRendererElement(warningStyle);
            }

            return null;
        }

    }
}
