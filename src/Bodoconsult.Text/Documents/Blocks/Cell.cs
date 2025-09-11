// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;

namespace Bodoconsult.Text.Documents;




/// <summary>
/// Table cell
/// </summary>
public class Cell : ParagraphBase
{
    /// <summary>
    /// Static list with all allowed inline elements for paragraphs
    /// </summary>
    public static List<Type> AllAllowedInlines =
    [
        typeof(Span),
        typeof(Bold),
        typeof(Italic),
        typeof(LineBreak)
    ];


    /// <summary>
    /// Default ctor
    /// </summary>
    public Cell()
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Cell");
    }

    /// <summary>
    /// Ctor with string content
    /// </summary>
    public Cell(string content)
    {
        // No blocks allowed

        // Add allowed inlines
        AllowedInlines.AddRange(AllAllowedInlines);

        TagToUse = string.Intern("Cell");

        Inlines.Add(new Value { Content = content });
    }

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="document">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder document, string indent)
    {
        document.AppendLine($"{indent}<{TagToUse}>");

        foreach (var item in Inlines)
        {
            item.ToLdmlString(document, $"{indent}{Indentation}");
        }

        document.AppendLine($"{indent}</{TagToUse}>");
    }
}

public class Column : Block
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Column()
    {
        // No blocks allowed

        // No inlines allowed

        TagToUse = string.Intern("Column");
    }

    /// <summary>
    /// Column data type
    /// </summary>
    public Type DataType { get; set; }

    /// <summary>
    /// Format string to format the value
    /// </summary>
    public string Format { get; set; }

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="document">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder document, string indent)
    {
        if (string.IsNullOrEmpty(Format))
        {
            document.AppendLine($"{indent}<{TagToUse} Name=\"{Name}\" DataType=\"{DataType}\"/>");
        }
        else
        {
            document.AppendLine($"{indent}<{TagToUse} Name=\"{Name}\" DataType=\"{DataType}\" Format=\"{Format}\"/>");
        }
    }
}

public class Row : Block
{
    /// <summary>
    /// Static list with all allowed inline elements for rows
    /// </summary>
    public static List<Type> AllAllowedBlocks =
    [
        typeof(Cell),
    ];

    /// <summary>
    /// Default ctor
    /// </summary>
    public Row()
    {
        // Blocks allowed

        // No inlines allowed

        TagToUse = string.Intern("Row");
    }

    /// <summary>
    /// Cells in the row
    /// </summary>
    public List<Cell> Cells { get; set; } = new();

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="document">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder document, string indent)
    {
        document.AppendLine($"{indent}<{TagToUse}>");
        document.AppendLine($"{indent}{Indentation}<Cells>");
        foreach (var cell in Cells)
        {
            cell.ToLdmlString(document, $"{indent}{Indentation}{Indentation}");
        }
        document.AppendLine($"{indent}{Indentation}</Cells>");
        document.AppendLine($"{indent}</{TagToUse}>");
    }
}

public class Table : Block
{

    /// <summary>
    /// Default ctor
    /// </summary>
    public Table()
    {
        // No blocks allowed

        // No inlines allowed

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