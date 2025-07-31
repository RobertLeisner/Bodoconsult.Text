// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Image text span
/// </summary>
public class Image : SpanBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Image()
    {
        // Add allowed child inlines

        // Tag to use
        TagToUse = string.Intern("Image");
    }

    /// <summary>
    /// Ctor to load content
    /// </summary>
    /// <param name="content">Content</param>
    public Image(string content)
    {
        // Add allowed child inlines

        // Tag to use
        TagToUse = string.Intern("Italic");

        Content = content;
    }

    /// <summary>
    /// URL of the image. Local file path, UNC path or a web link
    /// </summary>
    public string Uri { get; set; }
}