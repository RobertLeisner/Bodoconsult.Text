// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using Bodoconsult.Latex.Converters;
using Bodoconsult.Latex.Faking;
using Bodoconsult.Latex.Model;
using Bodoconsult.Latex.Services;
using Bodoconsult.Latex.Test.Helpers;
using NUnit.Framework;

namespace Bodoconsult.Latex.Test.Office;

[TestFixture]
public class UnitTestPresentationToLaTexConverterFakeAnalyzer : BasePresentationToLaTexConverter
{

    [SetUp]
    public void Setup()
    {

        LatexWriterService = new LatexV2WriterService(TargetPath);

        var presentation = new PresentationMetaData(Source);

        TestHelper.FillPresentation(presentation);

        Analyzer = new FakeAnalyzer(presentation);

        Converter = new PresentationToLaTexConverter(Analyzer, LatexWriterService);

    }
}