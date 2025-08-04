// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Citation
/// </summary>
public class Citation : ParagraphBase
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
    public Citation()
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Citation");
    }

    /// <summary>
    /// Ctor with string content
    /// </summary>
    public Citation(string content)
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Citation");

        Inlines.Add(new Span() { Content = content });
    }
}