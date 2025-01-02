// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.IO;
using Bodoconsult.Latex.Model;
using Bodoconsult.Latex.Services;
using NUnit.Framework;

namespace Bodoconsult.Latex.Test.Office
{
    public class UnitTestsPowerpoin2016PresentationConverterService: BasePresentationConverterService
    {
        [Test]
        public void TestConvert()
        {

            // Arrange
            Job = new PresentationJob
            {
                PresentationFilePath = @"D:\Daten\Projekte\Customer\Royotech\RTTower\StSysServer\Documentation\FindSlot.pptx",
                LaTexFilePath = @"D:\Daten\Projekte\Customer\Royotech\RTTower\StSysServer\Documentation\FindSlot.tex"
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
}