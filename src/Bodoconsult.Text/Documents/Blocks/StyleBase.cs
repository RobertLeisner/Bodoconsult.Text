// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Base type for styles for a document
/// </summary>
public abstract class StyleBase : Block
{

    /// <summary>
    /// The XML tag to ue for the current instance
    /// </summary>
    protected string TagToUse = string.Intern("Style");

    /// <summary>
    /// Default ctor
    /// </summary>
    protected StyleBase()
    {
        IsSingleton = true;
    }

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="document">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder document, string indent)
    {
        document.AppendLine($"{indent}<{TagToUse}{GetPropertiesAsAttributes()}/>");
    }
}