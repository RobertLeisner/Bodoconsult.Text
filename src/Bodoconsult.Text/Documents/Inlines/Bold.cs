// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Bold text span
/// </summary>
public class Bold : SpanBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Bold()
    {
        // Add allowed child inlines
        AllowedInlines.Add(typeof(Italic));
        AllowedInlines.Add(typeof(Hyperlink));

        // Tag to use
        TagToUse = string.Intern("Bold");
    }

    public Bold(string content)
    {
        // Add allowed child inlines
        AllowedInlines.Add(typeof(Italic));
        AllowedInlines.Add(typeof(Hyperlink));

        // Tag to use
        TagToUse = string.Intern("Bold");

        Content = content;
    }
}