// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Image text span
/// </summary>
public class Figure : SpanBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Figure()
    {
        // Add allowed child inlines
        AllowedInlines.Add(typeof(Bold));
        AllowedInlines.Add(typeof(Italic));
        AllowedInlines.Add(typeof(Hyperlink));

        // Tag to use
        TagToUse = string.Intern("Image");
    }

    /// <summary>
    /// Ctor to load content
    /// </summary>
    /// <param name="content">Content</param>
    public Figure(string content)
    {
        // Add allowed child inlines
        AllowedInlines.Add(typeof(Bold));
        AllowedInlines.Add(typeof(Hyperlink));

        // Tag to use
        TagToUse = string.Intern("Italic");

        Content = content;
    }

    /// <summary>
    /// URL of the image. Local file path, UNC path or a web link
    /// </summary>
    public string Uri { get; set; }
}