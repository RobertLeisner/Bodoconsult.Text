// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using System.IO;
using System.Runtime.Versioning;
using Bodoconsult.Text.Model;
using Bodoconsult.Text.Pdf.Test.Helpers;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Bodoconsult.Text.Pdf.Test;

[SupportedOSPlatform("windows")]
[TestFixture]
public class PdfTextFormatterTests
{
    [Test]
    public void TestCreatePdf()
    {

        var fileName = Path.Combine(TestHelper.TempPath, "TextPdf.pdf");

        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }

        Assert.That(File.Exists(fileName), Is.False);

        var st = new StructuredText();

        st.AddHeader1("Überschrift 1");

        st.AddParagraph(TestHelper.Masstext1);

        var code = FileHelper.GetTextResource("code1.txt");

        st.AddCode(code);

        st.AddParagraph(TestHelper.Masstext1);

        st.AddDefinitionListLine("Left1", "Right1");
        st.AddDefinitionListLine("Left2", "Right2");
        st.AddDefinitionListLine("Left3", "Right3");
        st.AddDefinitionListLine("Left4", "Right4");

        st.AddParagraph(TestHelper.Masstext1);

        st.AddTable("Tabelle", TestHelper.GetDataTable());

        st.AddHeader1("Überschrift 2");

        st.AddDefinitionListLine("Left1", "Right1");
        st.AddDefinitionListLine("Left2", "Right2");
        st.AddDefinitionListLine("Left3", "Right3");
        st.AddDefinitionListLine("Left4", "Right4");

        var f = new PdfTextFormatter
        {
            Title = "Testreport",
            StructuredText = st,
            DateString = $"Date created: {DateTime.Now:G}",
            Author = "Testautor"

        };
        f.GetFormattedText();
        f.SaveAsFile(fileName);

        FileAssert.Exists(fileName);

        TestHelper.OpenFile(fileName);
    }
}