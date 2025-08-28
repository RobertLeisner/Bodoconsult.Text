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
    ///  Default font name
    /// </summary>
    public const string DefaultFontNameMonoSpaced = "Courier New";

    /// <summary>
    /// Default color for borders and fonts
    /// </summary>
    public static Color DefaultColor = Colors.Black;

    /// <summary>
    /// Default border width in pt
    /// </summary>
    public const int DefaultBorderWidth = 1;

    /// <summary>
    /// Default padding width in pt
    /// </summary>
    public const int DefaultPaddingWidth = 6;

    /// <summary>
    /// Default font size in pt
    /// </summary>
    public const int DefaultFontSize = 12;

    /// <summary>
    /// Default margin left. Default 1cm = 28.3pt
    /// </summary>
    public static double DefaultMarginLeft { get; set; } = 28.3;

    /// <summary>
    /// Default margin right. Default 1cm = 28.3pt
    /// </summary>
    public static double DefaultMarginRight { get; set; } = 28.3;

    /// <summary>
    /// Default ctor
    /// </summary>
    public Document()
    {
        // Add all allowed blocks
        AllowedBlocks.Add(typeof(Section));
        AllowedBlocks.Add(typeof(DocumentMetaData));
        AllowedBlocks.Add(typeof(Styleset));
        AllowedBlocks.Add(typeof(TocSection));
        AllowedBlocks.Add(typeof(ToeSection));
        AllowedBlocks.Add(typeof(TofSection));

        // No inlines allowed

        // Tag to use
        TagToUse = string.Intern("Document");
    }

    /// <summary>
    /// Styleset to use for the document
    /// </summary>
    [DoNotSerialize]
    public Styleset Styleset { get; private set; }

    /// <summary>
    /// Metadata to use for the document
    /// </summary>
    [DoNotSerialize]
    public DocumentMetaData DocumentMetaData { get; private set; }

    /// <summary>
    /// Current TOC section or null if no TOC is required 
    /// </summary>
    [DoNotSerialize]
    public TocSection TocSection { get; private set; }

    /// <summary>
    /// Current TOF section or null if no TOF is required 
    /// </summary>
    [DoNotSerialize]
    public TofSection TofSection { get; private set; }

    /// <summary>
    /// Current TOE section or null if no TOE is required 
    /// </summary>
    [DoNotSerialize]
    public ToeSection ToeSection { get; private set; }

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

    /// <summary>
    /// Add a block element
    /// </summary>
    /// <param name="block">Block element to add</param>
    public override void AddBlock(Block block)
    {
        base.AddBlock(block);

        switch (block)
        {
            case Styleset styleset:
                Styleset = styleset;
                return;
            case DocumentMetaData documentMetaData:
                DocumentMetaData = documentMetaData;
                return;
            case TocSection tocSection:
                TocSection = tocSection;
                return;
            case TofSection tofSection:
                TofSection = tofSection;
                return;
            case ToeSection toeSection:
                ToeSection = toeSection;
                return;
        }
    }
}