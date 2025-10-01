// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using MigraDoc.DocumentObjectModel;

namespace Bodoconsult.Pdf.Stylesets;

/// <summary>
/// Defines a default style set.Use subclassing for creating advanced stylesets
/// </summary>
public class DefaultStyleSet : IStyleSet
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public DefaultStyleSet()
    {

        double verticalMargin = 3;

        PageSetup = new PageSetup
        {
            Orientation = Orientation.Portrait,
            PageFormat = PageFormat.A4,
            PageWidth = Unit.FromCentimeter(21.0),
            PageHeight = Unit.FromCentimeter(29.7),
            LeftMargin = Unit.FromCentimeter(3),
            TopMargin = Unit.FromCentimeter(2.5),
            RightMargin = Unit.FromCentimeter(1.5),
            BottomMargin = Unit.FromCentimeter(2.5)
        };

        Unit defaultFontSize = 11;

        var width = PageSetup.PageWidth - PageSetup.LeftMargin - PageSetup.RightMargin;

        Empty = new Style("Empty", null)
        {
            Font =
            {
                Name = "Arial",
                Size = 2,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = 0,
                SpaceAfter = 0,
                LineSpacing = 0.2,
                PageBreakBefore = false,
                Alignment = ParagraphAlignment.Left,
            }
        };

        Normal = new Style("Normal", null)
        {
            Font =
            {
                Name = "Arial",
                Size =  defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin,
                PageBreakBefore = false,
                Alignment = ParagraphAlignment.Left,

            }
        };

        //Normal.ParagraphFormat.Borders.Left.Width = 1;
        //Normal.ParagraphFormat.Borders.Left.Color = Colors.Black;

        ParagraphRight = new Style("ParagraphRight", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size =  defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin,
                PageBreakBefore = false,
                Alignment = ParagraphAlignment.Right,
            }
        };

        ParagraphCenter = new Style("ParagraphCenter", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size =  defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin,
                PageBreakBefore = false,
                Alignment = ParagraphAlignment.Center,
            }
        };

        ParagraphJustify = new Style("ParagraphJustify", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size =  defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin,
                PageBreakBefore = false,
                Alignment = ParagraphAlignment.Justify,
            }
        };

        NormalTable = new Style("NormalTable", "Normal")
        {
            Font =
            {
                Name = "Arial Narrow",
                Size = defaultFontSize-2
            },
            ParagraphFormat =
            {
                SpaceBefore = 3 * verticalMargin,
                SpaceAfter = 3 * verticalMargin,
                PageBreakBefore = false,
                Alignment = ParagraphAlignment.Center
            }
        };

        Heading1 = new Style("Heading1", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+7,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                PageBreakBefore = true,
                KeepTogether = true,
                KeepWithNext = true,
                SpaceAfter = 6 * verticalMargin,
                SpaceBefore = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Left,
            }
        };

        AddBorder(Heading1, Colors.Black, 0, 0, 0, 2);

        Heading2 = new Style("Heading2", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+5,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                KeepTogether = true,
                KeepWithNext = true,
                SpaceAfter = 3 * verticalMargin,
                SpaceBefore = 4 * verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };
        AddBorder(Heading2, Colors.Black, 0, 0, 0, 1);

        Heading3 = new Style("Heading3", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize+3,
                Color = Colors.Black,
                Bold = true
            },
            ParagraphFormat =
            {
                KeepTogether = true,
                KeepWithNext = true,
                SpaceAfter = verticalMargin,
                SpaceBefore = 2 * verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };


        Heading4 = new Style("Heading4", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize+1,
                Color = Colors.Black,
                Bold = true
            },
            ParagraphFormat =
            {
                KeepTogether = true,
                KeepWithNext = true,
                SpaceAfter = verticalMargin,
                SpaceBefore = verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };

        Heading5 = new Style("Heading5", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize+1,
                Color = Colors.Black,
                Italic = true
            },
            ParagraphFormat =
            {
                KeepTogether = true,
                KeepWithNext = true,
                SpaceAfter = verticalMargin,
                SpaceBefore = verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };


        Title = new Style("Title", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+7,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceAfter = 5 * verticalMargin,
                SpaceBefore = 30 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        SectionTitle = new Style("SectionTitle", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+7,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceAfter = 4 * verticalMargin,
                SpaceBefore = 30 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        Subtitle = new Style("Subtitle", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+7,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceAfter = 4 * verticalMargin,
                SpaceBefore = 5 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        SectionSubtitle = new Style("SectionSubtitle", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+5,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceAfter = 4 * verticalMargin,
                SpaceBefore = 5 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };


        NoHeading1 = new Style("NoHeading1", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size =  defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceAfter = verticalMargin,
                SpaceBefore = 2 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        //style.ParagraphFormat.
        //style.ParagraphFormat.Shading.Color = Colors.Orange;


        ChartTitle = new Style("ChartTitle", "Normal")
        {
            Font =
            {
                Name = "Arial Narrow",
                Size =  defaultFontSize,
                Bold = true,
                Color = Colors.Red
            },
            ParagraphFormat =
            {
                SpaceBefore = 1.5 * verticalMargin,
                Alignment = ParagraphAlignment.Center,
                SpaceAfter = 1.5 * verticalMargin
            }
        };

        ChartYLabel = new Style("ChartYLabel", "Normal")
        {
            Font =
            {
                Name = "Arial Narrow",
                Size = defaultFontSize - 2,
                Color = Colors.Black
            }
        };

        TocHeading = new Style("TocHeading", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+7,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                PageBreakBefore = true,
                KeepTogether = true,
                KeepWithNext = true,
                SpaceAfter = verticalMargin,
                SpaceBefore = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };

        AddBorder(TocHeading, Colors.Black, 0, 0, 0, 2);


        Toc1 = new Style("TOC1", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size =  defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = 2 * verticalMargin,
                SpaceAfter = verticalMargin
            }
        };

        Toc1.ParagraphFormat.Borders.Bottom.Width = 0;
        Toc1.ParagraphFormat.Borders.Top.Width = 0;
        Toc1.ParagraphFormat.Borders.Right.Width = 0;
        Toc1.ParagraphFormat.Borders.Left.Width = 0;
        Toc1.ParagraphFormat.TabStops.AddTabStop(width, TabAlignment.Right);

        Toc2 = new Style("TOC2", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = 2 * verticalMargin,
                SpaceAfter = verticalMargin
            }
        };

        Toc2.ParagraphFormat.Borders.Bottom.Width = 0;
        Toc2.ParagraphFormat.Borders.Top.Width = 0;
        Toc2.ParagraphFormat.Borders.Right.Width = 0;
        Toc2.ParagraphFormat.Borders.Left.Width = 0;
        Toc2.ParagraphFormat.LeftIndent = Unit.FromCentimeter(1);
        Toc2.ParagraphFormat.TabStops.AddTabStop(width, TabAlignment.Right);

        Toc3 = new Style("TOC3", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin
            }
        };

        Toc3.ParagraphFormat.Borders.Bottom.Width = 0;
        Toc3.ParagraphFormat.Borders.Top.Width = 0;
        Toc3.ParagraphFormat.Borders.Right.Width = 0;
        Toc3.ParagraphFormat.Borders.Left.Width = 0;
        Toc3.ParagraphFormat.LeftIndent = Unit.FromCentimeter(2);
        Toc3.ParagraphFormat.TabStops.AddTabStop(width, TabAlignment.Right);

        Toc4 = new Style("TOC4", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin
            }
        };

        Toc4.ParagraphFormat.Borders.Bottom.Width = 0;
        Toc4.ParagraphFormat.Borders.Top.Width = 0;
        Toc4.ParagraphFormat.Borders.Right.Width = 0;
        Toc4.ParagraphFormat.Borders.Left.Width = 0;
        Toc4.ParagraphFormat.LeftIndent = Unit.FromCentimeter(3);
        Toc4.ParagraphFormat.TabStops.AddTabStop(width, TabAlignment.Right);

        Toc5 = new Style("TOC5", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin
            }
        };

        Toc5.ParagraphFormat.Borders.Bottom.Width = 0;
        Toc5.ParagraphFormat.Borders.Top.Width = 0;
        Toc5.ParagraphFormat.Borders.Right.Width = 0;
        Toc5.ParagraphFormat.Borders.Left.Width = 0;
        Toc5.ParagraphFormat.LeftIndent = Unit.FromCentimeter(4);
        Toc5.ParagraphFormat.TabStops.AddTabStop(width, TabAlignment.Right);


        //TocHeading = new Style("TocHeading1", "Normal")
        //{
        //    Font =
        //    {
        //        Name = "Arial Black",
        //        Size = 12,
        //        Color = Colors.Black
        //    },
        //    ParagraphFormat = { SpaceAfter = verticalMargin }
        //};
        //TocHeading.ParagraphFormat.SpaceAfter = verticalMargin;
        //TocHeading.ParagraphFormat.Alignment = ParagraphAlignment.Center;

        ToeHeading = new Style("ToeHeading", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+ 7,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                PageBreakBefore = true,
                KeepTogether = true,
                KeepWithNext = true,
                SpaceAfter = 3 * verticalMargin,
                SpaceBefore = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };
        AddBorder(ToeHeading, Colors.Black, 0, 0, 0, 2);

        Toe = new Style("Toe", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size =  defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceAfter = verticalMargin,
                SpaceBefore = 0,
                Alignment = ParagraphAlignment.Left
            }
        };
        Toe.ParagraphFormat.TabStops.AddTabStop(width, TabAlignment.Right);

        TofHeading = new Style("TofHeading", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+ 7,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                PageBreakBefore = true,
                KeepTogether = true,
                KeepWithNext = true,
                SpaceAfter = 3 * verticalMargin,
                SpaceBefore = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };
        AddBorder(TofHeading, Colors.Black, 0, 0, 0, 2);

        Tof = new Style("Tof", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceAfter = verticalMargin,
                SpaceBefore = 0,
                Alignment = ParagraphAlignment.Left
            }
        };
        Tof.ParagraphFormat.TabStops.AddTabStop(width, TabAlignment.Right);

        TotHeading = new Style("TotHeading", "Normal")
        {
            Font =
            {
                Name = "Arial Black",
                Size = defaultFontSize+ 7,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                PageBreakBefore = true,
                KeepTogether = true,
                KeepWithNext = true,
                SpaceAfter = 3 * verticalMargin,
                SpaceBefore = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };
        AddBorder(TotHeading, Colors.Black, 0, 0, 0, 2);

        Tot = new Style("Tot", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceAfter = verticalMargin,
                SpaceBefore = 0,
                Alignment = ParagraphAlignment.Left
            }
        };
        Tot.ParagraphFormat.TabStops.AddTabStop(width, TabAlignment.Right);

        // Kopfzeile
        Header = new Style("Header", "Normal")
        {
            Font =
            {
                Name = "Arial Narrow",
                Size = defaultFontSize- 2,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                Alignment = ParagraphAlignment.Right,
                SpaceAfter = 0,
                SpaceBefore = 0
            }
        };
        Header.ParagraphFormat.Borders.Bottom.Width = 1;
        Header.ParagraphFormat.Borders.Bottom.Color = Colors.Black;
        Header.ParagraphFormat.AddTabStop(width, TabAlignment.Right);

        Details = new Style("Details", "Normal")
        {
            Font =
            {
                Name = "Arial Narrow",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceAfter = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        Citation = new Style("Citation", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = 2 * verticalMargin,
                SpaceAfter = 0,
                Alignment = ParagraphAlignment.Center
            }
        };

        CitationSource = new Style("CitationSource", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black,
                Italic = true
            },
            ParagraphFormat =
            {
                SpaceAfter = verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        Info = new Style("Info", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = 2 * verticalMargin,
                SpaceAfter = verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };
        AddBorder(Info, Colors.Black, 1);

        Warning = new Style("Warning", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black,
            },
            ParagraphFormat =
            {
                SpaceBefore = 2 * verticalMargin,
                SpaceAfter = verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };
        AddBorder(Warning, Colors.Yellow, 1);

        Error = new Style("Error", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = 2 * verticalMargin,
                SpaceAfter = verticalMargin,
                Alignment = ParagraphAlignment.Left
            }
        };
        AddBorder(Error, Colors.Red, 1);


        Table = new Style("Table", "Normal")
        {
            Font =
            {
                Name = "Arial Narrow",
                Size = defaultFontSize- 2,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = 3 * verticalMargin,
                SpaceAfter = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        TableLegend = new Style("TableLegend", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black,
            },
            ParagraphFormat =
            {
                SpaceAfter = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        FigureLegend = new Style("FigureLegend", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black,
            },
            ParagraphFormat =
            {
                SpaceAfter = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        EquationLegend = new Style("EquationLegend", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black,
            },
            ParagraphFormat =
            {
                SpaceAfter = 3 * verticalMargin,
                Alignment = ParagraphAlignment.Center
            }
        };

        ChartCell = new Style("ChartCell", "Normal")
        {
            ParagraphFormat = { Alignment = ParagraphAlignment.Center }
        };

        Footer = new Style("Footer", "Normal")
        {
            Font =
            {
                Name = "Arial Narrow",
                Size = defaultFontSize- 2,
                Color = Colors.Black
            },
            ParagraphFormat =
            {

                Alignment = ParagraphAlignment.Left,
                SpaceAfter = 0,
                SpaceBefore = 0
            }
        };

        Footer.ParagraphFormat.Borders.Top.Visible = true;
        Footer.ParagraphFormat.Borders.Top.Width = 0.5;
        Footer.ParagraphFormat.Borders.Top.Color = Colors.Black;
        Footer.ParagraphFormat.AddTabStop(width, TabAlignment.Right);

        Code = new Style("Code", "Normal")
        {
            Font =
            {
                Name = "Courier New",
                Size = defaultFontSize- 2,
                Color = Colors.Black,
                Italic = false,
                Bold = false
            },
            ParagraphFormat =
            {
                Alignment = ParagraphAlignment.Left,
                SpaceBefore = 2 * verticalMargin,
                SpaceAfter = 2 * verticalMargin
            }
        };
        Code.ParagraphFormat.TabStops.ClearAll();
        Code.ParagraphFormat.TabStops.AddTabStop("0.5cm");
        Code.ParagraphFormat.TabStops.AddTabStop("1cm");
        Code.ParagraphFormat.TabStops.AddTabStop("1.5cm");
        Code.ParagraphFormat.TabStops.AddTabStop("2cm");
        Code.ParagraphFormat.TabStops.AddTabStop("2.5cm");
        Code.ParagraphFormat.TabStops.AddTabStop("3cm");
        Code.ParagraphFormat.TabStops.AddTabStop("3.5cm");
        Code.ParagraphFormat.TabStops.AddTabStop("4cm");
        Code.ParagraphFormat.TabStops.AddTabStop("4.5cm");
        Code.ParagraphFormat.TabStops.AddTabStop("5cm");
        //Code.ParagraphFormat.TabStops.AddTabStop("6cm");
        //Code.ParagraphFormat.TabStops.AddTabStop("7cm");
        //Code.ParagraphFormat.TabStops.AddTabStop("8cm");
        //Code.ParagraphFormat.TabStops.AddTabStop("9cm");
        //Code.ParagraphFormat.TabStops.AddTabStop("10cm");
        //Code.ParagraphFormat.TabStops.AddTabStop("11cm");
        //Code.ParagraphFormat.TabStops.AddTabStop("12cm");
        //Code.ParagraphFormat.TabStops.AddTabStop("13cm");
        //Code.ParagraphFormat.TabStops.AddTabStop("14cm");
        Code.ParagraphFormat.TabStops.AddTabStop("26.7cm", TabAlignment.Right);


        Bullet1 = new Style("Bullet1", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size = defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                Alignment = ParagraphAlignment.Left,
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin
            }
        };
        Bullet1.ParagraphFormat.AddTabStop("26.7cm", TabAlignment.Right);
        Bullet1.ParagraphFormat.LeftIndent = Unit.FromCentimeter(1);
        var li = new ListInfo { ListType = ListType.BulletList1 };
        Bullet1.ParagraphFormat.ListInfo = li;

        DefinitionListTerm = new Style("DefinitionListTerm", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size =  defaultFontSize,
                Color = Colors.Black,
                Italic = true
            },
            ParagraphFormat =
            {
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin,
                PageBreakBefore = false,
                Alignment = ParagraphAlignment.Left,
            }
        };

        DefinitionListItem = new Style("DefinitionListItem", "Normal")
        {
            Font =
            {
                Name = "Arial",
                Size =  defaultFontSize,
                Color = Colors.Black
            },
            ParagraphFormat =
            {
                SpaceBefore = verticalMargin,
                SpaceAfter = verticalMargin,
                PageBreakBefore = false,
                Alignment = ParagraphAlignment.Left,
            }
        };

    }

    private void AddBorder(Style style, Color color, int left, int top, int right, int bottom)
    {
        if (left > 0)
        {
            style.ParagraphFormat.Borders.Left.Width = left;
            style.ParagraphFormat.Borders.Left.Color = color;
            style.ParagraphFormat.Borders.Left.Visible = true;
            style.ParagraphFormat.Borders.DistanceFromLeft = 5;
        }
        if (top > 0)
        {
            style.ParagraphFormat.Borders.Top.Width = top;
            style.ParagraphFormat.Borders.Top.Color = color;
            style.ParagraphFormat.Borders.Top.Visible = true;
            style.ParagraphFormat.Borders.DistanceFromTop = 5;
        }
        if (right > 0)
        {
            style.ParagraphFormat.Borders.Right.Width = right;
            style.ParagraphFormat.Borders.Right.Color = color;
            style.ParagraphFormat.Borders.Right.Visible = true;
            style.ParagraphFormat.Borders.DistanceFromRight = 5;
        }
        if (bottom > 0)
        {
            style.ParagraphFormat.Borders.Bottom.Width = bottom;
            style.ParagraphFormat.Borders.Bottom.Color = color;
            style.ParagraphFormat.Borders.Bottom.Visible = true;
            style.ParagraphFormat.Borders.DistanceFromBottom = 5;
        }
    }

    /// <summary>
    /// Add a border to a style
    /// </summary>
    /// <param name="style">Current style</param>
    /// <param name="color">Border color</param>
    /// <param name="width">Border with</param>
    private static void AddBorder(Style style, Color color, Unit width)
    {
        style.ParagraphFormat.Borders.Bottom.Width = width;
        style.ParagraphFormat.Borders.Bottom.Color = color;
        style.ParagraphFormat.Borders.Bottom.Visible = true;
        style.ParagraphFormat.Borders.DistanceFromBottom = 5;

        style.ParagraphFormat.Borders.Top.Width = width;
        style.ParagraphFormat.Borders.Top.Color = color;
        style.ParagraphFormat.Borders.Top.Visible = true;
        style.ParagraphFormat.Borders.DistanceFromTop = 5;

        style.ParagraphFormat.Borders.Left.Width = width;
        style.ParagraphFormat.Borders.Left.Color = color;
        style.ParagraphFormat.Borders.Left.Visible = true;
        style.ParagraphFormat.Borders.DistanceFromLeft = 5;

        style.ParagraphFormat.Borders.Right.Width = width;
        style.ParagraphFormat.Borders.Right.Color = color;
        style.ParagraphFormat.Borders.Right.Visible = true;
        style.ParagraphFormat.Borders.DistanceFromRight = 5;
    }

    /// <summary>
    /// Style for definition list item
    /// </summary>
    public Style DefinitionListItem { get; }

    /// <summary>
    /// Normal paragraphs (default style)
    /// </summary>
    public PageSetup PageSetup { get; set; }



    /// <summary>
    /// Normal paragraphs (default style)
    /// </summary>
    public Style Normal { get; }

    /// <summary>
    /// Centered paragraph style
    /// </summary>
    public Style ParagraphCenter { get; set; }

    /// <summary>
    /// Right-aligned paragraph style
    /// </summary>
    public Style ParagraphRight { get; set; }

    /// <summary>
    /// Justified paragraph style
    /// </summary>
    public Style ParagraphJustify { get; set; }

    /// <summary>
    /// Style used a table base. Do NOT change this style
    /// </summary>
    public Style NormalTable { get; }

    /// <summary>
    /// Table format
    /// </summary>
    public Style Table { get; }
    
    /// <summary>
    /// Style used for table legends
    /// </summary>
    public Style TableLegend { get; }

    /// <summary>
    /// Style used for figure legends
    /// </summary>
    public Style FigureLegend { get; }

    /// <summary>
    /// Style used for equation legends
    /// </summary>
    public Style EquationLegend { get; }

    /// <summary>
    /// Style for TOC section heading
    /// </summary>
    public Style TocHeading { get; }

    /// <summary>
    /// Title
    /// </summary>
    public Style Title { get; }

    /// <summary>
    /// Subtitle
    /// </summary>
    public Style Subtitle { get; }

    /// <summary>
    /// Section title
    /// </summary>
    public Style SectionTitle { get; }

    /// <summary>
    /// Section subtitle
    /// </summary>
    public Style SectionSubtitle { get; }

    /// <summary>
    /// Heading level 1
    /// </summary>
    public Style Heading1 { get; }

    /// <summary>
    /// Heading level 2
    /// </summary>
    public Style Heading2 { get; }

    /// <summary>
    /// Heading level 3
    /// </summary>
    public Style Heading3 { get; }

    /// <summary>
    /// Heading level 4
    /// </summary>
    public Style Heading4 { get; }

    /// <summary>
    /// Heading level 5
    /// </summary>
    public Style Heading5 { get; }

    /// <summary>
    /// No heading 1 for small tables
    /// </summary>
    public Style NoHeading1 { get; }

    /// <summary>
    /// Chart title style
    /// </summary>
    public Style ChartTitle { get; }

    /// <summary>
    /// Chart y-axis label style
    /// </summary>
    public Style ChartYLabel { get; }

    /// <summary>
    /// Style for TOC heading 1
    /// </summary>
    public Style Toc1 { get; }

    /// <summary>
    /// Style for TOC heading 2
    /// </summary>
    public Style Toc2 { get; }

    /// <summary>
    /// Style for TOC heading 3
    /// </summary>
    public Style Toc3 { get; }

    /// <summary>
    /// Style for TOC heading 4
    /// </summary>
    public Style Toc4 { get; }

    /// <summary>
    /// Style for TOC heading 5
    /// </summary>
    public Style Toc5 { get; }

    /// <summary>
    /// Style for TOE section heading
    /// </summary>
    public Style ToeHeading { get; }

    /// <summary>
    /// Style for TOE entry
    /// </summary>
    public Style Toe { get; }

    /// <summary>
    /// Style for TOF section heading
    /// </summary>
    public Style TofHeading { get; }

    /// <summary>
    /// Style for TOE entry
    /// </summary>
    public Style Tof { get; }

    /// <summary>
    /// Style for TOT section heading
    /// </summary>
    public Style TotHeading { get; }

    /// <summary>
    /// Style for TOE entry
    /// </summary>
    public Style Tot { get; }

    /// <summary>
    /// Page header style
    /// </summary>
    public Style Header { get; }

    /// <summary>
    /// Details style
    /// </summary>
    public Style Details { get; }

    /// <summary>
    /// Chart cell style
    /// </summary>
    public Style ChartCell { get; }

    /// <summary>
    /// Page footer style
    /// </summary>
    public Style Footer { get; }

    /// <summary>
    /// Style for code segment paragraphs
    /// </summary>
    public Style Code { get; }

    /// <summary>
    /// Style for info segment paragraphs
    /// </summary>
    public Style Info { get; }

    /// <summary>
    /// Style for warning segment paragraphs
    /// </summary>
    public Style Warning { get; }

    /// <summary>
    /// Style for error segment paragraphs
    /// </summary>
    public Style Error { get; }

    /// <summary>
    /// Style for citation segment paragraphs
    /// </summary>
    public Style Citation { get; }

    /// <summary>
    /// Style for citation source segment paragraphs
    /// </summary>
    public Style CitationSource { get; }

    /// <summary>
    /// A style for bulleted lists
    /// </summary>
    public Style Bullet1 { get; }

    /// <summary>
    /// A style to add empty space of make margins top on pages possible
    /// </summary>
    public Style Empty { get; }

    /// <summary>
    /// Style for definition list term
    /// </summary>
    public Style DefinitionListTerm { get; }
}