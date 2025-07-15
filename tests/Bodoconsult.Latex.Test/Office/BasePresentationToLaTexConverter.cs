// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.IO;
using Bodoconsult.Latex.Interfaces;
using Bodoconsult.Latex.Test.Helpers;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Bodoconsult.Latex.Test.Office
{
    public abstract class BasePresentationToLaTexConverter
    {

        protected ILatexWriterService LatexWriterService;

        protected IPresentationToLaTexConverter Converter;

        protected IPresentationAnalyzer Analyzer;


        protected string TargetPath = Path.Combine(TestHelper.TempPath, "chapter1.tex");


        protected string Source = Path.Combine(TestHelper.TestDataPath, "Test.pptx");

        [Test]
        public void TestCtor()
        {

            // Act: see Setup()

            // Assert
            Assert.That(Analyzer.PresentationMetaData, Is.Not.Null);
            Assert.That(Analyzer.PresentationMetaData.SourceFileName, Is.EqualTo(Source));

            Assert.That(Converter.Analyzer.PresentationMetaData, Is.Not.Null);
            Assert.That(Converter.Analyzer.PresentationMetaData.SourceFileName, Is.EqualTo(Source));

        }


        [Test]
        public void TestConvert()
        {

            // Arrange
            if (File.Exists(Converter.LaTexWriterService.FileName))
            {
                File.Delete(Converter.LaTexWriterService.FileName);
            }

            // Act: see Setup()
            var result = Converter.Convert();

            // Assert
            Assert.That(result, Is.Not.Null);

            Assert.That(string.IsNullOrEmpty(result.Trim()), Is.False);

            FileAssert.Exists(Converter.LaTexWriterService.FileName);

            TestHelper.PrintPresentation(Analyzer.PresentationMetaData);

        }
    }
}