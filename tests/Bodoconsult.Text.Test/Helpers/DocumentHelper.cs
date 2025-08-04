// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Test.Helpers;

public static class DocumentHelper
{
    public const string MassText =
        "Lorem ipsum dolor ≥ = &gt; &#61; sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";

    public static Document CreateDocument()
    {
        var doc = new Document
        {
            Name = "MyReport"
        };

        // Styleset
        var styleset = StylesetHelper.CreateDefaultStyleset();
        doc.AddBlock(styleset);


        // Meta data
        var meta = new DocumentMetaData()
        {
            Company = "Bodoconsult GmbH",
            CompanyWebsite = "http://www.bodoconsult.de",
            Authors = "Robert Leisner"
        };

        doc.AddBlock(meta);

        // New section
        var section = new Section
        {
            Name = "Body"
        };

        doc.AddBlock(section);

        // Add a Title
        var title = new Title("Title");
        section.AddBlock(title);

        // Add a Subtitle
        var subtitle = new Subtitle("Subtitle");
        section.AddBlock(subtitle);

        // Add a Toc1
        var toc1 = new Toc1("Toc1");
        section.AddBlock(toc1);

        // Add a Toc2
        var toc2 = new Toc2("Toc2");
        section.AddBlock(toc2);

        // Add a Toc3
        var toc3 = new Toc3("Toc3");
        section.AddBlock(toc3);

        // Add a Toc4
        var toc4= new Toc4("Toc4");
        section.AddBlock(toc4);

        // Add a Toc5
        var toc5 = new Toc5("Toc5");
        section.AddBlock(toc5);

        // Add a SectionTitle
        var sectionTitle = new SectionTitle("SectionTitle");
        section.AddBlock(sectionTitle);
        // Add a SectionTitle
        var sectionSubtitle = new SectionSubtitle("SectionSubtitle");
        section.AddBlock(sectionSubtitle);

        // Add a heading level 1
        var heading1 = new Heading1("Heading level 1");
        section.AddBlock(heading1);

        // Add a heading level 2
        var heading2 = new Heading2("Heading level 2");
        section.AddBlock(heading2);

        // Add a heading level 3
        var heading3 = new Heading3("Heading level 3");
        section.AddBlock(heading3);

        // Add a heading level 3
        var heading4 = new Heading4("Heading level 4");
        section.AddBlock(heading4);

        // Add a heading level 3
        var heading5 = new Heading5("Heading level 5");
        section.AddBlock(heading5);

        // Add a Info
        var info = new Info("Info");
        section.AddBlock(info);

        // Add a simple paragraph
        var paragraph = new Paragraph("Blubb blabb didl dumm");
        section.AddBlock(paragraph);

        // Add a simple Central paragraph
        var paragraphCentral = new ParagraphCenter("Blubb blabb didl dumm");
        section.AddBlock(paragraphCentral);

        // Add a simple Right paragraph
        var paragraphRight = new ParagraphRight("Blubb blabb didl dumm");
        section.AddBlock(paragraphRight);

        // Add a simple Justify paragraph
        var paragraphJustify = new ParagraphJustify("Blubb blabb didl dumm");
        section.AddBlock(paragraphJustify);

        // Add a paragraph with multiple inlines
        paragraph = new Paragraph();

        //   Add a simple span
        var span = new Span(DocumentHelper.MassText);
        paragraph.AddInline(span);

        //   Add a line break
        paragraph.AddInline(new LineBreak());

        //   Add bold text
        var bold = new Bold(DocumentHelper.MassText);
        paragraph.AddInline(bold);

        section.AddBlock(paragraph);

        // Add a bold and italic text paragraph
        var bold2 = new Bold(DocumentHelper.MassText);

        var italic = new Italic();
        italic.AddInline(bold2);

        paragraph = new Paragraph();
        paragraph.AddInline(italic);
        section.AddBlock(paragraph);

        // Add a Citation
        var citation = new Citation("Citation");
        section.AddBlock(citation);

        // Add a code
        var code = new Code("Code");
        section.AddBlock(code);

        // Add an error
        var error = new Error("Error");
        section.AddBlock(error);

        // Add a Warning
        var warning = new Warning("Warning");
        section.AddBlock(warning);

        // Add a hyperlink
        paragraph = new Paragraph("This is a link: ");
        var link = new Hyperlink("Link to blubb")
        {
            Uri = "http://www.bodoconsult.de"
        };
        paragraph.AddInline(link);
        section.AddBlock(paragraph);

        // Add an image
        var image = new Image("Test image", TestHelper.TestChartImage);
        section.AddBlock(image);

        // Add a figure 1
        var figure1 = new Image("Figure 1", TestHelper.TestChartImage);
        section.AddBlock(figure1);

        // Add a figure 2
        var figure2 = new Image("Figure 2", TestHelper.TestDistributionImage);
        section.AddBlock(figure2);

        // Add an equation 1
        var equiation1 = new Equation("Equiation 1", TestHelper.TestEquiationImage);
        section.AddBlock(equiation1);

        // Add an equation 2
        var equiation2 = new Equation("Equiation 2", TestHelper.TestEquiationImage);
        section.AddBlock(equiation2);

        // Add a list
        var list = new List();

        var listItem1 = new ListItem("First list item");
        list.AddBlock(listItem1);

        var listItem2 = new ListItem("Second list item");
        list.AddBlock(listItem2);

        section.AddBlock(list);

        return doc;
    }
}
