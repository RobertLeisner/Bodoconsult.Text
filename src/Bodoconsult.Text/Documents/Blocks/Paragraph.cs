// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Paragraph block element
/// </summary>
public class Paragraph: ParagraphBase
{

    /// <summary>
    /// Static list with all allowed inline elements for paragraphs
    /// </summary>
    public static List<Type>AllAllowedInlines =
    [
        typeof(Span),
        typeof(Bold),
        typeof(Italic),
        typeof(LineBreak),
        typeof(Hyperlink),
        typeof(Image),
        typeof(Figure),
        typeof(Equation)
    ];


    /// <summary>
    /// Default ctor
    /// </summary>
    public Paragraph()
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        // Tag
        TagToUse = string.Intern("Paragraph");
    }

    /// <summary>
    /// Ctor with string content
    /// </summary>
    public Paragraph(string content)
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        // Tag
        TagToUse = string.Intern("Paragraph");

        // Content
        Inlines.Add(new Span { Content = content});
    }

    /// <summary>
    /// Add a block element
    /// </summary>
    /// <param name="block">Block element to add</param>
    public override void AddBlock(Block block)
    {
        // Do nothing
    }

}