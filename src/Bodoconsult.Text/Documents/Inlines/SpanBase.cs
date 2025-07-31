// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// A span base element contains plain text
/// </summary>
public abstract class SpanBase : Inline
{
    private string _content;

    /// <summary>
    /// The XML tag to ue for the current instance
    /// </summary>
    protected string TagToUse = string.Intern("Span");

    /// <summary>
    /// The content of the span element. May only be set if there is no inline child element loaded
    /// </summary>
    [DoNotSerialize]
    public string Content
    {
        get => _content;
        set
        {
            if (Inlines.Count > 0)
            {
                return;
            }

            _content = value;
        }
    }

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="stringBuilder">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder stringBuilder, string indent)
    {
        if (Inlines.Count > 0)
        {
            AddTagWithAttributes(indent, TagToUse, stringBuilder);

            // Add the inlines now
            foreach (var inline in Inlines)
            {
                inline.ToLdmlString(stringBuilder, $"{indent}{Indentation}");
            }

            stringBuilder.AppendLine($"{indent}</{TagToUse}>");
        }
        else
        {
            AddTagWithAttributes(indent, TagToUse, stringBuilder, false);

            // Add content now
            stringBuilder.AppendLine($"{Content}</{TagToUse}>");
        }
    }

    /// <summary>
    /// Add a block element
    /// </summary>
    /// <param name="inline">Inline element to add</param>
    public override void AddInline(Inline inline)
    {
        var type = inline.GetType();

        if (!AllowedInlines.Contains(type))
        {
            throw new ArgumentException($"Type {type.Name} not allowed to add for the current element");
        }

        Inlines.Add(inline);
        inline.Parent = this;
    }
}