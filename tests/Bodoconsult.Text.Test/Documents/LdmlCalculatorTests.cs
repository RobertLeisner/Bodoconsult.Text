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
        Assert.That(lc.FigureCounter, Is.EqualTo(0));
        Assert.That(lc.Equations, Is.Not.Null);
        Assert.That(lc.EquationCounter, Is.EqualTo(0));
        Assert.That(lc.ToeItems, Is.Not.Null);
        Assert.That(lc.TofItems, Is.Not.Null);

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

    [Test]
    public void PrepareAllItemsForToe_ValidDocument_EquationsLoaded()
    {
        // Arrange 
        var doc = TestDataHelper.CreateDocument();
        var lc = new LdmlCalculator(doc);

        lc.EnumerateAllItemsForToe();

        // Act  
        lc.PrepareAllItemsForToe();

        // Assert
        Assert.That(lc.ToeItems.Count, Is.Not.EqualTo(0));
    }

    [Test]
    public void EnumerateAllItemsForTof_ValidDocument_FiguresLoaded()
    {
        // Arrange 
        var doc = TestDataHelper.CreateDocument();
        var lc = new LdmlCalculator(doc);

        // Act  
        lc.EnumerateAllItemsForTof();

        // Assert
        Assert.That(lc.Document, Is.Not.Null);
        Assert.That(lc.Figures.Count, Is.Not.EqualTo(0));
        Assert.That(lc.FigureCounter, Is.Not.EqualTo(0));

        var eq = lc.Figures[0];

        Assert.That(eq.CurrentPrefix.Length, Is.Not.EqualTo(0));
        Assert.That(eq.TagName.Length, Is.Not.EqualTo(0));
    }

    [Test]
    public void PrepareAllItemsForTof_ValidDocument_FiguresLoaded()
    {
        // Arrange 
        var doc = TestDataHelper.CreateDocument();
        var lc = new LdmlCalculator(doc);

        lc.EnumerateAllItemsForTof();

        // Act  
        lc.PrepareAllItemsForTof();

        // Assert
        Assert.That(lc.TofItems.Count, Is.Not.EqualTo(0));
    }

}