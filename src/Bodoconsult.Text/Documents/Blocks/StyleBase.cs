// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Base type for styles for a document
/// </summary>
public abstract class StyleBase : Block
{

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
    /// <param name="stringBuilder">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder stringBuilder, string indent)
    {
        stringBuilder.AppendLine($"{indent}<Style{GetPropertiesAsAttributes()}/>");
    }
}