// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Test.Helpers;
using NUnit.Framework;

namespace Bodoconsult.Text.Test.Documents;

[TestFixture]
public class LdmlCalculatorTests
{
    [Test]
    public void Ctor_ValidDocument_PropsSetCorrectly()
    {
        // Arrange 
        var doc = TestDataHelper.CreateDocument();

        // Act  
        var lc = new LdmlCalculator(doc);

        // Assert
        Assert.That(lc.Document, Is.Not.Null);
        Assert.That(lc.Figures, Is.Not.Null);
        Assert.That(lc.FigurCounter, Is.EqualTo(0));
        Assert.That(lc.Equations, Is.Not.Null);
        Assert.That(lc.EquationCounter, Is.EqualTo(0));

    }

    [Test]
    public void EnumerateAllItemsForToe_ValidDocument_EquationsLoaded()
    {
        // Arrange 
        var doc = TestDataHelper.CreateDocument();
        var lc = new LdmlCalculator(doc);

        // Act  
        lc.EnumerateAllItemsForToe();

        // Assert
        Assert.That(lc.Document, Is.Not.Null);
        Assert.That(lc.Equations.Count, Is.Not.EqualTo(0));
        Assert.That(lc.EquationCounter, Is.Not.EqualTo(0));

        var eq = lc.Equations[0];

        Assert.That(eq.CurrentPrefix.Length, Is.Not.EqualTo(0));
        Assert.That(eq.TagName.Length, Is.Not.EqualTo(0));
    }


}