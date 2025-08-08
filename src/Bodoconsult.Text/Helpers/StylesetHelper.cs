// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Helpers;

/// <summary>
/// Helper class to generate <see cref="Styleset"/> instances
/// </summary>
public static class StylesetHelper
{
    /// <summary>
    ///  Create a default style set
    /// </summary>
    /// <returns></returns>
    public static Styleset CreateDefaultStyleset()
    {
        var styleSet = new Styleset
        {
            Name = "Default"
        };

        // Add document style
        styleSet.AddBlock(new DocumentStyle());
        styleSet.AddBlock(new SectionStyle());
        styleSet.AddBlock(new TocSectionStyle());
        styleSet.AddBlock(new TofSectionStyle());
        styleSet.AddBlock(new ToeSectionStyle());

        // Add style <see cref="CitationStyle"/> for <see cref="Citation"/> instances 
        var citationStyle = new CitationStyle();
        styleSet.AddBlock(citationStyle);

        // Add style <see cref="CodeStyle"/> for <see cref="Code"/> instances 
        var codeStyle = new CodeStyle();
        styleSet.AddBlock(codeStyle);

        // Add style <see cref="EquationStyle"/> for <see cref="Equation"/> instances 
        var equationStyle = new EquationStyle();
        styleSet.AddBlock(equationStyle);

        // Add style <see cref="ErrorStyle"/> for <see cref="Error"/> instances 
        var errorStyle = new ErrorStyle();
        styleSet.AddBlock(errorStyle);

        // Add style <see cref="FigureStyle"/> for <see cref="Figure"/> instances 
        var figureStyle = new FigureStyle();
        styleSet.AddBlock(figureStyle);

        // Add style <see cref="Heading1Style"/> for <see cref="Heading1"/> instances 
        var heading1Style = new Heading1Style();
        styleSet.AddBlock(heading1Style);

        // Add style <see cref="Heading2Style"/> for <see cref="Heading2"/> instances 
        var heading2Style = new Heading2Style();
        styleSet.AddBlock(heading2Style);

        // Add style <see cref="Heading3Style"/> for <see cref="Heading3"/> instances 
        var heading3Style = new Heading3Style();
        styleSet.AddBlock(heading3Style);

        // Add style <see cref="Heading4Style"/> for <see cref="Heading4"/> instances 
        var heading4Style = new Heading4Style();
        styleSet.AddBlock(heading4Style);

        // Add style <see cref="Heading5Style"/> for <see cref="Heading5"/> instances 
        var heading5Style = new Heading5Style();
        styleSet.AddBlock(heading5Style);

        // Add style <see cref="ImageStyle"/> for <see cref="Image"/> instances 
        var imageStyle = new ImageStyle();
        styleSet.AddBlock(imageStyle);

        // Add style <see cref="InfoStyle"/> for <see cref="Info"/> instances 
        var infoStyle = new InfoStyle();
        styleSet.AddBlock(infoStyle);

        // Add style <see cref="ListStyle"/> for <see cref="List"/> instances 
        var listStyle = new ListStyle();
        styleSet.AddBlock(listStyle);

        // Add style <see cref="ListItemStyle"/> for <see cref="ListItem"/> instances 
        var listitemStyle = new ListItemStyle();
        styleSet.AddBlock(listitemStyle);

        // Add style <see cref="ParagraphStyle"/> for <see cref="Paragraph"/> instances 
        var paragraphStyle = new ParagraphStyle();
        styleSet.AddBlock(paragraphStyle);

        // Add style <see cref="ParagraphCenterStyle"/> for <see cref="ParagraphCenter"/> instances 
        var paragraphcenterStyle = new ParagraphCenterStyle();
        styleSet.AddBlock(paragraphcenterStyle);

        // Add style <see cref="ParagraphJustifyStyle"/> for <see cref="ParagraphJustify"/> instances 
        var paragraphjustifyStyle = new ParagraphJustifyStyle();
        styleSet.AddBlock(paragraphjustifyStyle);

        // Add style <see cref="ParagraphRightStyle"/> for <see cref="ParagraphRight"/> instances 
        var paragraphrightStyle = new ParagraphRightStyle();
        styleSet.AddBlock(paragraphrightStyle);

        // Add style <see cref="SectionSubtitleStyle"/> for <see cref="SectionSubtitle"/> instances 
        var sectionsubtitleStyle = new SectionSubtitleStyle();
        styleSet.AddBlock(sectionsubtitleStyle);

        // Add style <see cref="SectionTitleStyle"/> for <see cref="SectionTitle"/> instances 
        var sectiontitleStyle = new SectionTitleStyle();
        styleSet.AddBlock(sectiontitleStyle);

        // Add style <see cref="SubtitleStyle"/> for <see cref="Subtitle"/> instances 
        var subtitleStyle = new SubtitleStyle();
        styleSet.AddBlock(subtitleStyle);

        // Add style <see cref="TitleStyle"/> for <see cref="Title"/> instances 
        var titleStyle = new TitleStyle();
        styleSet.AddBlock(titleStyle);

        // Add style <see cref="Toc1Style"/> for <see cref="Toc1"/> instances 
        var toc1Style = new Toc1Style();
        styleSet.AddBlock(toc1Style);

        // Add style <see cref="Toc2Style"/> for <see cref="Toc2"/> instances 
        var toc2Style = new Toc2Style();
        styleSet.AddBlock(toc2Style);

        // Add style <see cref="Toc3Style"/> for <see cref="Toc3"/> instances 
        var toc3Style = new Toc3Style();
        styleSet.AddBlock(toc3Style);

        // Add style <see cref="Toc4Style"/> for <see cref="Toc4"/> instances 
        var toc4Style = new Toc4Style();
        styleSet.AddBlock(toc4Style);

        // Add style <see cref="Toc5Style"/> for <see cref="Toc5"/> instances 
        var toc5Style = new Toc5Style();
        styleSet.AddBlock(toc5Style);

        // Add style <see cref="WarningStyle"/> for <see cref="Warning"/> instances 
        var warningStyle = new WarningStyle();
        styleSet.AddBlock(warningStyle);

        return styleSet;



    }

    /// <summary>
    ///  Create a default style set
    /// </summary>
    /// <returns></returns>
    public static Styleset CreateTestStyleset()
    {
        var styleSet = new Styleset
        {
            Name = "Default"
        };

        // Add document style
        styleSet.AddBlock(new DocumentStyle());
        styleSet.AddBlock(new SectionStyle());
        styleSet.AddBlock(new TocSectionStyle());
        styleSet.AddBlock(new TofSectionStyle());
        styleSet.AddBlock(new ToeSectionStyle());

        // Add style <see cref="CitationStyle"/> for <see cref="Citation"/> instances 
        var citationStyle = new CitationStyle();
        styleSet.AddBlock(citationStyle);

        // Add style <see cref="CodeStyle"/> for <see cref="Code"/> instances 
        var codeStyle = new CodeStyle();
        styleSet.AddBlock(codeStyle);

        // Add style <see cref="EquationStyle"/> for <see cref="Equation"/> instances 
        var equationStyle = new EquationStyle();
        styleSet.AddBlock(equationStyle);

        // Add style <see cref="ErrorStyle"/> for <see cref="Error"/> instances 
        var errorStyle = new ErrorStyle();
        styleSet.AddBlock(errorStyle);

        // Add style <see cref="FigureStyle"/> for <see cref="Figure"/> instances 
        var figureStyle = new FigureStyle();
        styleSet.AddBlock(figureStyle);

        // Add style <see cref="Heading1Style"/> for <see cref="Heading1"/> instances 
        var heading1Style = new Heading1Style
        {
            BorderBrush = new SolidColorBrush(Colors.Aqua)
        };
        styleSet.AddBlock(heading1Style);

        // Add style <see cref="Heading2Style"/> for <see cref="Heading2"/> instances 
        var heading2Style = new Heading2Style();
        styleSet.AddBlock(heading2Style);

        // Add style <see cref="Heading3Style"/> for <see cref="Heading3"/> instances 
        var heading3Style = new Heading3Style();
        styleSet.AddBlock(heading3Style);

        // Add style <see cref="Heading4Style"/> for <see cref="Heading4"/> instances 
        var heading4Style = new Heading4Style();
        styleSet.AddBlock(heading4Style);

        // Add style <see cref="Heading5Style"/> for <see cref="Heading5"/> instances 
        var heading5Style = new Heading5Style();
        styleSet.AddBlock(heading5Style);

        // Add style <see cref="ImageStyle"/> for <see cref="Image"/> instances 
        var imageStyle = new ImageStyle();
        styleSet.AddBlock(imageStyle);

        // Add style <see cref="InfoStyle"/> for <see cref="Info"/> instances 
        var infoStyle = new InfoStyle();
        styleSet.AddBlock(infoStyle);

        // Add style <see cref="ListStyle"/> for <see cref="List"/> instances 
        var listStyle = new ListStyle();
        styleSet.AddBlock(listStyle);

        // Add style <see cref="ListItemStyle"/> for <see cref="ListItem"/> instances 
        var listitemStyle = new ListItemStyle();
        styleSet.AddBlock(listitemStyle);

        // Add style <see cref="ParagraphStyle"/> for <see cref="Paragraph"/> instances 
        var paragraphStyle = new ParagraphStyle();
        styleSet.AddBlock(paragraphStyle);

        // Add style <see cref="ParagraphCenterStyle"/> for <see cref="ParagraphCenter"/> instances 
        var paragraphcenterStyle = new ParagraphCenterStyle();
        styleSet.AddBlock(paragraphcenterStyle);

        // Add style <see cref="ParagraphJustifyStyle"/> for <see cref="ParagraphJustify"/> instances 
        var paragraphjustifyStyle = new ParagraphJustifyStyle();
        styleSet.AddBlock(paragraphjustifyStyle);

        // Add style <see cref="ParagraphRightStyle"/> for <see cref="ParagraphRight"/> instances 
        var paragraphrightStyle = new ParagraphRightStyle();
        styleSet.AddBlock(paragraphrightStyle);

        // Add style <see cref="SectionSubtitleStyle"/> for <see cref="SectionSubtitle"/> instances 
        var sectionsubtitleStyle = new SectionSubtitleStyle();
        styleSet.AddBlock(sectionsubtitleStyle);

        // Add style <see cref="SectionTitleStyle"/> for <see cref="SectionTitle"/> instances 
        var sectiontitleStyle = new SectionTitleStyle();
        styleSet.AddBlock(sectiontitleStyle);

        // Add style <see cref="SubtitleStyle"/> for <see cref="Subtitle"/> instances 
        var subtitleStyle = new SubtitleStyle();
        styleSet.AddBlock(subtitleStyle);

        // Add style <see cref="TitleStyle"/> for <see cref="Title"/> instances 
        var titleStyle = new TitleStyle();
        styleSet.AddBlock(titleStyle);

        // Add style <see cref="Toc1Style"/> for <see cref="Toc1"/> instances 
        var toc1Style = new Toc1Style();
        styleSet.AddBlock(toc1Style);

        // Add style <see cref="Toc2Style"/> for <see cref="Toc2"/> instances 
        var toc2Style = new Toc2Style();
        styleSet.AddBlock(toc2Style);

        // Add style <see cref="Toc3Style"/> for <see cref="Toc3"/> instances 
        var toc3Style = new Toc3Style();
        styleSet.AddBlock(toc3Style);

        // Add style <see cref="Toc4Style"/> for <see cref="Toc4"/> instances 
        var toc4Style = new Toc4Style();
        styleSet.AddBlock(toc4Style);

        // Add style <see cref="Toc5Style"/> for <see cref="Toc5"/> instances 
        var toc5Style = new Toc5Style();
        styleSet.AddBlock(toc5Style);

        // Add style <see cref="WarningStyle"/> for <see cref="Warning"/> instances 
        var warningStyle = new WarningStyle();
        styleSet.AddBlock(warningStyle);

        return styleSet;



    }

}