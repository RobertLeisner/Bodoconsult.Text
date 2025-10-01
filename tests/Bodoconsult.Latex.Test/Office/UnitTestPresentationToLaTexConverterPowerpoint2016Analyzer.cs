// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using Bodoconsult.Latex.Converters;
using Bodoconsult.Latex.Office.Analyzer;
using Bodoconsult.Latex.Services;
using NUnit.Framework;

namespace Bodoconsult.Latex.Test.Office;

[TestFixture]
public class UnitTestPresentationToLaTexConverterPowerpoint2016Analyzer : BasePresentationToLaTexConverter
{

    [SetUp]
    public void Setup()
    {
        LatexWriterService = new LatexV2WriterService(TargetPath);

        Analyzer = new Powerpoint2016Analyzer(Source);

        Converter = new PresentationToLaTexConverter(Analyzer, LatexWriterService);

    }
}