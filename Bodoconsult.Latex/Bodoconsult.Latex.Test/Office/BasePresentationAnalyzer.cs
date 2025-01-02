// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using Bodoconsult.Latex.Interfaces;
using Bodoconsult.Latex.Test.Helpers;
using NUnit.Framework;

namespace Bodoconsult.Latex.Test.Office
{
    /// <summary>
    /// Base class for test for <see cref="IPresentationAnalyzer"/> instances
    /// </summary>
    public abstract class BasePresentationAnalyzer
    {

        protected IPresentationAnalyzer Analyzer;


        protected string Source;

        [Test]
        public void TestCtor()
        {

            // Act: see Setup()

            // Assert
            Assert.IsNotNull(Analyzer.PresentationMetaData);
            Assert.AreEqual(Source, Analyzer.PresentationMetaData.SourceFileName);

        }


        [Test]
        public void TestAnalyse()
        {

            // Act
            Analyzer.Analyse();

            // Assert
            Assert.IsNotNull(Analyzer.PresentationMetaData);
            Assert.AreEqual(Source, Analyzer.PresentationMetaData.SourceFileName);


            TestHelper.PrintPresentation(Analyzer.PresentationMetaData);

        }


    }
}
