// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Toc4
/// </summary>
public class Toc4: TocBase
{
   


    /// <summary>
    /// Default ctor
    /// </summary>
    public Toc4()
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Toc4");
    }

    /// <summary>
    /// Ctor with string content
    /// </summary>
    public Toc4(string content)
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Toc4");

        Inlines.Add(new Span(){Content = content});
    }
}