// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.IO;
using Bodoconsult.Latex.Converters;
using Bodoconsult.Latex.Office.Analyzer;
using Bodoconsult.Latex.Services;
using Bodoconsult.Latex.Test.Helpers;
using NUnit.Framework;

namespace Bodoconsult.Latex.Test.Office;

[TestFixture]
public class UnitTestPresentationToLaTexConverterPowerpoint2016AnalyzerRealWorld : BasePresentationToLaTexConverter
{

    [SetUp]
    public void Setup()
    {

        Source = Path.Combine(TestHelper.TestDataPath, "Grundkurs Wirtschaft.pptx");
        TargetPath = Path.Combine(TestHelper.TempPath, "GrundkursWirtschaft.tex");

        LatexWriterService = new LatexV2WriterService(TargetPath);

        Analyzer = new Powerpoint2016Analyzer(Source);

        Converter = new PresentationToLaTexConverter(Analyzer, LatexWriterService);

    }
}