// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Styleset for a document
/// </summary>
public class Styleset : Block
{

    private List<string> _keys;

    /// <summary>
    /// Current style dictionary. Do not use directly. Public for testing only
    /// </summary>
    public readonly Dictionary<string, StyleBase> StyleDictionary = new();

    /// <summary>
    /// Default ctor
    /// </summary>
    public Styleset()
    {
        IsSingleton = true;
    }

    /// <summary>
    /// Get the index of the stylename
    /// </summary>
    /// <param name="styleName">Stylename</param>
    /// <returns>Index of the stylename</returns>
    public int GetIndexOfStyle(string styleName)
    {
        _keys ??= StyleDictionary.Keys.ToList();
        var index = _keys.IndexOf(styleName);
        return index;
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

        if (block is not StyleBase sb)
        {
            throw new ArgumentException($"Type {type.Name} not allowed to be added to a styleset");
        }

        Blocks.Add(block);
        block.Parent = this;

        StyleDictionary.Add(block.GetType().Name, sb);
    }

    /// <summary>
    /// Find a style
    /// </summary>
    /// <param name="name">Nme of the style to find</param>
    /// <returns>Found style or null</returns>
    public StyleBase FindStyle(string name)
    {
        var result = StyleDictionary.TryGetValue(name, out var sb);
        return result ? sb : null;
    }
}