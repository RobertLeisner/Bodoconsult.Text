// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Represents a document section. Every document has ho have at least one section
/// </summary>
public class Section : Block
{

    /// <summary>
    /// Static list with all allowed inline elements for paragraphs
    /// </summary>
    public static List<Type> AllAllowedBlocks =
    [
        typeof(Paragraph),
        typeof(Heading1),
        typeof(Heading2),
    ];

        

    /// <summary>
    /// Default ctor
    /// </summary>
    public Section()
    {
        // Add all allowed blocks
        AllowedBlocks.AddRange(AllAllowedBlocks);

        // No inlines allowed
    }



    /// <summary>
    /// Include this section in the table of content
    /// </summary>
    public bool IncludeInToc { get; set; }

    /// <summary>
    /// Add a page break before the section
    /// </summary>
    public bool PageBreakBefore { get; set; }


    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="stringBuilder">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder stringBuilder, string indent)
    {
        AddTagWithAttributes(indent, "Section", stringBuilder);

        // Add the blocks now
        foreach (var block in ChildBlocks)
        {
            block.ToLdmlString(stringBuilder, $"{indent}{Indentation}");
        }

        stringBuilder.AppendLine($"{indent}</Section>");
    }

    /// <summary>
    /// Add an inline element: not allowed on document level
    /// </summary>
    /// <param name="inline">Inline element to add</param>
    public override void AddInline(Inline inline)
    {
        // Do nothing
    }
}