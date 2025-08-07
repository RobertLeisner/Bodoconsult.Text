// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
///  base class for all <see cref="Document"/> related LDML objects
/// </summary>
public abstract class DocumentElement
{
    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="document">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public virtual void ToLdmlString(StringBuilder document, string indent)
    {
        throw new NotSupportedException("Create an override for method ToLdmlString()");
    }
}

/// <summary>
/// A property element produces as an attribute in LDML
/// </summary>
public abstract class PropertyAsAttributeElement: DocumentElement
{
    /// <summary>
    /// Get the element data as formatted property value for an LDML attribute
    /// </summary>
    public virtual string ToPropertyValue()
    {
        throw new NotSupportedException("Create an override for method ToPropertyValue()");
    }
}

/// <summary>
/// A property element produces as a block in LDML
/// </summary>
public abstract class PropertyAsBlockElement : DocumentElement
{
    /// <summary>
    /// Get the element data as formatted property value as a LDML block
    /// </summary>
    public virtual string ToPropertyValue()
    {
        throw new NotSupportedException("Create an override for method ToPropertyValue()");
    }
}