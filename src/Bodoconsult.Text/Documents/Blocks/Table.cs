// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// A table
/// </summary>
public class Table : Block
{

    /// <summary>
    /// Static list with all allowed inline elements for paragraphs
    /// </summary>
    public static List<Type> AllAllowedInlines =
    [
        typeof(Span),
        typeof(Bold),
        typeof(Italic),
        typeof(LineBreak),
    ];

    /// <summary>
    /// Default ctor
    /// </summary>
    public Table()
    {
        // No blocks allowed

        // No inlines allowed
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Table");
    }

    /// <summary>
    /// Ctor providing a table legend
    /// </summary>
    public Table(string content)
    {
        // No blocks allowed

        // No inlines allowed
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Table");
    }

    /// <summary>
    /// Columns of the table
    /// </summary>
    public List<Column> Columns { get; set; } = new();

    /// <summary>
    /// Rows of the table
    /// </summary>
    public List<Row> Rows { get; set; } = new();

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="document">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder document, string indent)
    {
        document.AppendLine($"{indent}<{TagToUse}>");
        
        document.AppendLine($"{indent}{Indentation}<Columns>");
        foreach (var column in Columns)
        {
            column.ToLdmlString(document, indent + Indentation+Indentation);
        }
        document.AppendLine($"{indent}{Indentation}</Columns>");

        document.AppendLine($"{indent}{Indentation}<Rows>");
        foreach (var row in Rows)
        {
            row.ToLdmlString(document, indent + Indentation + Indentation);
        }
        document.AppendLine($"{indent}{Indentation}</Rows>");

        document.AppendLine($"{indent}</{TagToUse}>");
    }

}