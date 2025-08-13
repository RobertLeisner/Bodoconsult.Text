// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using Bodoconsult.Text.Reports;
using Bodoconsult.Text.Test.TestData;
using NUnit.Framework;

namespace Bodoconsult.Text.Test.Reports
{
    [TestFixture]
    internal class ReportBaseTests
    {

        [Test]
        public void Ctor_ValidSetup_PropsSetCorrectly()
        {
            // Arrange 

            // Act  
            var report = new TestReport();

            // Assert
            Assert.That(report.Document, Is.Not.Null);
            Assert.That(report.CurrentSection, Is.Null);
        }

        [Test]
        public void CreateNewSection_ValidSetup_SectionCreatedAndLoaded()
        {
            // Arrange 
            var report = new TestReport();

            // Act  
            report.CreateNewSection("Body");

            // Assert
            Assert.That(report.Document, Is.Not.Null);
            Assert.That(report.CurrentSection, Is.Not.Null);
        }

        [Test]
        public void LoadDocumentMetaData_ValidSetup_MetaDataLoaded()
        {
            // Arrange 
            var report = new TestReport();
            var metaData = new DocumentMetaData();
            
            // Act  
            report.LoadDocumentMetaData(metaData);

            // Assert
            Assert.That(report.DocumentMetaData, Is.Not.Null);
            Assert.That(report.DocumentMetaData, Is.EqualTo(metaData));
        }

        [Test]
        public void LoadStyleset_ValidSetup_StyleSetLoaded()
        {
            // Arrange 
            var report = new TestReport();
            var styleset = StylesetHelper.CreateDefaultStyleset();

            // Act  
            report.LoadStyleset(styleset);

            // Assert
            Assert.That(report.Styleset, Is.Not.Null);
            Assert.That(report.Styleset, Is.EqualTo(styleset));
        }

        [Test]
        public void PrepareTheDocument_ValidSetup_MetadataAndStyleSetLoadedBodySectionCreated()
        {
            // Arrange 
            var report = new TestReport();

            // Act  
            report.PrepareTheDocument();

            // Assert
            Assert.That(report.Styleset, Is.Not.Null);
            Assert.That(report.CurrentSection, Is.Not.Null);

            Assert.That(report.Document.ChildBlocks.Count, Is.EqualTo(3));
            Assert.That(report.Document.ChildBlocks[0].GetType(), Is.EqualTo(typeof(DocumentMetaData)));
            Assert.That(report.Document.ChildBlocks[1].GetType(), Is.EqualTo(typeof(Styleset)));
            Assert.That(report.Document.ChildBlocks[2].GetType(), Is.EqualTo(typeof(Section)));
        }

        [Test]
        public void AddHeading_Level1_Heading1Added()
        {
            // Arrange 
            var report = new TestReport();
            report.PrepareTheDocument();

            // Act  
            report.AddHeading(HeadingLevel.Level1, "Blubb");

            // Assert
            var section = report.Document.ChildBlocks[2] as Section;
            Assert.That(section, Is.Not.Null);

            Assert.That(report.Styleset, Is.Not.Null);
            Assert.That(report.CurrentSection, Is.Not.Null);

            Assert.That(section.ChildBlocks.Count, Is.EqualTo(1));
            Assert.That(section.ChildBlocks[0].GetType(), Is.EqualTo(typeof(Heading1)));
        }

        // ToDo: add tests for level2 to level 5

        // ToDo: add tests for AppParagraph

    }
}
