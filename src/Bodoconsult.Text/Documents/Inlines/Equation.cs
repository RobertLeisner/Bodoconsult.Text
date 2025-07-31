// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Documents;

//  https://github.com/verybadcat/CSharpMath

/// <summary>
/// Equation text span
/// </summary>
public class Equation : SpanBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Equation()
    {
        // Add allowed child inlines

        // Tag to use
        TagToUse = string.Intern("Equation");
    }

    /// <summary>
    /// Ctor to load content
    /// </summary>
    /// <param name="content">Content</param>
    public Equation(string content)
    {
        // Add allowed child inlines

        // Tag to use
        TagToUse = string.Intern("Equation");

        Content = content;
    }

    /// <summary>
    /// URL of the equation image. Local file path, UNC path or a web link
    /// </summary>
    public string Uri { get; set; }

    /// <summary>
    /// Math equation in LaTex notation
    /// </summary>
    public string LaTex { get; set; }

    /// <summary>
    /// Math equation in MathML notation
    /// </summary>
    public string MathMl { get; set; }
}