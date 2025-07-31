// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Base class for aragraph block element
/// </summary>
public abstract class ParagraphBase : Block
{

    /// <summary>
    /// The XML tag to ue for the current instance
    /// </summary>
    protected string TagToUse = string.Intern("Paragraph");

    /// <summary>
    /// Add a block element
    /// </summary>
    /// <param name="block">Block element to add</param>
    public override void AddBlock(Block block)
    {
        // Do nothing
    }

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="stringBuilder">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder stringBuilder, string indent)
    {
        AddTagWithAttributes(indent, TagToUse, stringBuilder);

        // Add the blocks now
        foreach (var block in ChildBlocks)
        {
            block.ToLdmlString(stringBuilder, $"{indent}{Indentation}");
        }

        // Add the inlines now
        foreach (var inline in Inlines)
        {
            inline.ToLdmlString(stringBuilder, $"{indent}{Indentation}");
        }


        stringBuilder.AppendLine($"{indent}</{TagToUse}>");
    }


}