// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.IO;
using Bodoconsult.Latex.Faking;
using Bodoconsult.Latex.Model;
using Bodoconsult.Latex.Test.Helpers;
using NUnit.Framework;

namespace Bodoconsult.Latex.Test.Office
{
    [TestFixture]
    public class UnitTestFakeAnalyzer : BasePresentationAnalyzer
    {

        [SetUp]
        public void Setup()
        {

            Source = Path.Combine(TestHelper.TestDataPath, "Test.pptx");

            var presentation = new PresentationMetaData(Source);

            TestHelper.FillPresentation(presentation);

            Analyzer = new FakeAnalyzer(presentation);

        }


    }
}