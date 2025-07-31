// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Italic text span
/// </summary>
public class Hyperlink : SpanBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Hyperlink()
    {
        // Add allowed child inlines
        AllowedInlines.Add(typeof(Bold));
        AllowedInlines.Add(typeof(Italic));

        // Tag to use
        TagToUse = string.Intern("Hyperlink");
    }

    /// <summary>
    /// Ctor to load content
    /// </summary>
    /// <param name="content">Clear text description of the URL</param>
    public Hyperlink(string content)
    {
        // Add allowed child inlines

        // Tag to use
        TagToUse = string.Intern("Hyperlink");

        Content = content;
    }

    /// <summary>
    /// URL of the hyperlink
    /// </summary>
    public string Uri { get; set; }
}