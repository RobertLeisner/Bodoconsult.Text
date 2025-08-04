// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Document block element. Root element
/// </summary>
public class Document : Block
{
    /// <summary>
    ///  Default font name
    /// </summary>
    public const string DefaultFontName = "Calibri";

    /// <summary>
    /// Default font size
    /// </summary>
    public const int DefaultFontSize = 12;


    /// <summary>
    /// Default ctor
    /// </summary>
    public Document()
    {
        // Add all allowed blocks
        AllowedBlocks.Add(typeof(Section));
        AllowedBlocks.Add(typeof(DocumentMetaData));
        AllowedBlocks.Add(typeof(Styleset));

        // No inlines allowed

        // Tag to use
        TagToUse = string.Intern("Document");
    }

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="document">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder document, string indent)
    {
        AddTagWithAttributes(indent, TagToUse, document);

        // Add the blocks now
        foreach (var block in Blocks)
        {
            block.ToLdmlString(document, $"{indent}{Indentation}");
        }

        document.AppendLine($"{indent}</{TagToUse}>");
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