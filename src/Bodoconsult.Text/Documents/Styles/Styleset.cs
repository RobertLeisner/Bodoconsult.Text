// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Styleset for a document
/// </summary>
public class Styleset : Block
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Styleset()
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
        AddTagWithAttributes(indent, "Styleset", stringBuilder);

        // Add the blocks now
        foreach (var block in Blocks)
        {
            block.ToLdmlString(stringBuilder, $"{indent}{Indentation}");
        }

        stringBuilder.AppendLine($"{indent}</Styleset>");
    }

    /// <summary>
    /// Add a block element
    /// </summary>
    /// <param name="block">Block element to add</param>
    public override void AddBlock(Block block)
    {
        var type = block.GetType();

        if (block is not StyleBase)
        {
            throw new ArgumentException($"Type {type.Name} not allowed to be added to a styleset");
        }

        Blocks.Add(block);
        block.Parent = this;
    }

}