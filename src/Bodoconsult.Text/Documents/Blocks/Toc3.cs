// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Toc3
/// </summary>
public class Toc3 : ParagraphBase
{
    /// <summary>
    /// Static list with all allowed inline elements for paragraphs
    /// </summary>
    public static List<Type> AllAllowedInlines =
    [
        typeof(Span),
        typeof(Bold),
        typeof(Italic),
        typeof(LineBreak)
    ];


    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc3()
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Toc3");
    }

    /// <summary>
    /// Ctor with string content
    /// </summary>
    public Toc3(string content)
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Toc3");

        Inlines.Add(new Span(){Content = content});
    }
}