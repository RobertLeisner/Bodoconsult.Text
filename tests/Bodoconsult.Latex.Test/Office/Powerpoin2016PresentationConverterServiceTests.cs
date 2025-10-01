// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System.IO;
using Bodoconsult.Latex.Model;
using Bodoconsult.Latex.Services;
using Bodoconsult.Latex.Test.Helpers;
using NUnit.Framework;

namespace Bodoconsult.Latex.Test.Office;

public class Powerpoin2016PresentationConverterServiceTests: BasePresentationConverterService
{
    [Test]
    public void Convert_ExistingFile_LatexCreated()
    {

        // Arrange
        Job = new PresentationJob
        {
            PresentationFilePath = Path.Combine(TestHelper.TestDataPath, @"Grundkurs Wirtschaft.pptx"),
            LaTexFilePath = Path.Combine(TestHelper.TempPath , @"Grundkurs_Wirtschaft.tex")
        };

        if (File.Exists(Job.LaTexFilePath))
        {
            File.Delete(Job.LaTexFilePath);
        }

        Service = new Powerpoin2016PresentationConverterService(Job);

        // Act
        Service.ConvertPresentation();

        // Assert
        Assert.That(File.Exists(Job.LaTexFilePath));

    }

}