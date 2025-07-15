// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System.IO;
using Bodoconsult.Latex.Office.Analyzer;
using Bodoconsult.Latex.Test.Helpers;
using NUnit.Framework;

namespace Bodoconsult.Latex.Test.Office
{
    [TestFixture]
    public class Powerpoint2016AnalyzerTests : BasePresentationAnalyzer
    {

        [SetUp]
        public void Setup()
        {

            Source = Path.Combine(TestHelper.TestDataPath, "Test.pptx");

            Analyzer = new Powerpoint2016Analyzer(Source);

        }


    }
}