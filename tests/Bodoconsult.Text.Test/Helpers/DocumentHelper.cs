// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

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

        // Add a heading level 1
        var heading1 = new Heading1("Heading level 1");
        section.AddBlock(heading1);

        // Add a simple paragraph
        var paragraph = new Paragraph("Blubb blabb didl dumm");
        section.AddBlock(paragraph);

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

        // Add a hyperlink
        paragraph = new Paragraph("This is a link: ");
        var link = new Hyperlink("Link to blubb")
        {
            Uri = "http://www.bodoconsult.de"
        };
        paragraph.AddInline(link);
        section.AddBlock(paragraph);

        return doc;
    }
}
