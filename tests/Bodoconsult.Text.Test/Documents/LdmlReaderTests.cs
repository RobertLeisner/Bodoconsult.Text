// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.IO;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Test.Helpers;
using NUnit.Framework;

namespace Bodoconsult.Text.Test.Documents;

[TestFixture]
public class LdmlReaderTests
{

    [Test]
    public void Ctor_DefaultCtor_NoStringLoaded()
    {
        // Arrange 

        // Act  
        var r = new LdmlReader();

        // Assert
        Assert.That(string.IsNullOrEmpty(r.Ldml), Is.True);
    }

    [Test]
    public void Ctor_CtorLoadingString_StringLoaded()
    {
        // Arrange 
        var ldmlFile = Path.Combine(TestHelper.TestDataPath, "Document1.ldml");
        var ldml = File.ReadAllText(ldmlFile);

        // Act  
        var r = new LdmlReader(ldml);

        // Assert
        Assert.That(string.IsNullOrEmpty(r.Ldml), Is.False);
    }

    [Test]
    public void LoadLdmlFile_ExistingFile_StringLoaded()
    {
        // Arrange 
        var r = new LdmlReader();
        var ldmlFile = Path.Combine(TestHelper.TestDataPath, "Document1.ldml");

        // Act  
        r.LoadLdmlFile(ldmlFile);

        // Assert
        Assert.That(string.IsNullOrEmpty(r.Ldml), Is.False);
    }

    [Test]
    public void ParseLdml_ExistingFile_DocParsed()
    {
        // Arrange 
        var r = new LdmlReader();
        var ldmlFile = Path.Combine(TestHelper.TestDataPath, "Document1.ldml");

        r.LoadLdmlFile(ldmlFile);

        // Act  
        r.ParseLdml();

        // Assert
        Assert.That(r.TextElement, Is.Not.Null);
    }
}