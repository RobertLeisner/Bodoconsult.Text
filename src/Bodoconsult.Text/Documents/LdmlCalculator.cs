// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Collections.Generic;
using System.Linq;

namespace Bodoconsult.Text.Documents
{
    /// <summary>
    /// Calculate TOC, TOF and TOE content for a LDML document
    /// </summary>
    public class LdmlCalculator
    {
        private readonly DocumentMetaData _documentMetaData;

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="document">Current document to calculate</param>
        public LdmlCalculator(Document document)
        {
            Document = document;

            _documentMetaData = (DocumentMetaData)Document.ChildBlocks.FirstOrDefault(x => x.GetType() == typeof(DocumentMetaData));

            if (_documentMetaData != null)
            {
                _documentMetaData = new DocumentMetaData();
            }
        }

        /// <summary>
        /// Current document to calculate
        /// </summary>
        public Document Document { get;  }

        /// <summary>
        /// All figures in the document to count
        /// </summary>
        public List<Figure> Figures { get; } = new();

        /// <summary>
        /// All items of the TOF
        /// </summary>
        public List<Tof> TofItems { get; } = new();

        /// <summary>
        /// Current figure counter
        /// </summary>
        public int FigureCounter { get; private set; }

        /// <summary>
        /// All equations in the document to count
        /// </summary>
        public List<Equation> Equations { get; } = new();

        /// <summary>
        /// All items of the TOE
        /// </summary>
        public List<Toe> ToeItems { get; } = new();

        /// <summary>
        /// Current equation counter
        /// </summary>
        public int EquationCounter { get; private set; }


        /// <summary>
        /// Enumerate all items needed for TOC, TO´F and TOE
        /// </summary>
        public void EnumerateAllItems()
        {
            EnumerateAllItemsForToc();
            EnumerateAllItemsForToe();
            EnumerateAllItemsForTof();
        }

        /// <summary>
        /// Enumerate all items needed for TOC
        /// </summary>
        public void EnumerateAllItemsForToc()
        {


        }

        /// <summary>
        /// Enumerate all items needed for TOE
        /// </summary>
        public void EnumerateAllItemsForToe()
        {
            foreach (var item in Document.ChildBlocks)
            {
                // Only Section instances are interesting
                if (item is not Section section)
                {
                    continue;
                }

                // Current section is exluded from numbering
                if (section.DoNotIncludeInNumbering)
                {
                    continue;
                }

                // Now find the equations
                FindEquations(section);
            }
        }

        private void FindEquations(Section section)
        {
            
            foreach (var block in section.ChildBlocks)
            {
                if (block is not Equation equation)
                {
                    continue;
                }

                EquationCounter++;

                equation.TagName = $"Equation{EquationCounter}";
                equation.CurrentPrefix = $"{_documentMetaData.EquationPrefix} {EquationCounter}:";

                Equations.Add(equation);
            }
        }

        /// <summary>
        /// Enumerate all items needed for TOF
        /// </summary>
        public void EnumerateAllItemsForTof()
        {
            foreach (var item in Document.ChildBlocks)
            {
                // Only Section instances are interesting
                if (item is not Section section)
                {
                    continue;
                }

                // Current section is exluded from numbering
                if (section.DoNotIncludeInNumbering)
                {
                    continue;
                }

                // Now find the equations
                FindFigure(section);
            }

        }

        private void FindFigure(Section section)
        {

            foreach (var block in section.ChildBlocks)
            {
                if (block is not Figure figure)
                {
                    continue;
                }

                FigureCounter++;

                figure.TagName = $"Figure{FigureCounter}";
                figure.CurrentPrefix = $"{_documentMetaData.FigurePrefix} {FigureCounter}:";

                Figures.Add(figure);
            }
        }

        /// <summary>
        /// Prepare all items needed for TOC, TOE and TOF
        /// </summary>
        public void PrepareAllItemsc()
        {
            PrepareAllItemsForToc();
            PrepareAllItemsForToe();
            PrepareAllItemsForTof();
        }

        /// <summary>
        /// Prepare all items needed for TOC
        /// </summary>
        public void PrepareAllItemsForToc()
        {


        }

        /// <summary>
        /// Prepare all items needed for TOE
        /// </summary>
        public void PrepareAllItemsForToe()
        {
            if (Equations.Count == 0)
            {
                return;
            }

            foreach (var equation in Equations)
            {
                var toe = new Toe();

                foreach (var inline in equation.ChildInlines)
                {
                    toe.AddInline(inline);
                }

                ToeItems.Add(toe);
            }

        }

        /// <summary>
        /// Prepare all items needed for TOF
        /// </summary>
        public void PrepareAllItemsForTof()
        {

            if (Figures.Count == 0)
            {
                return;
            }

            foreach (var figure in Figures)
            {
                var tof = new Tof();

                foreach (var inline in figure.ChildInlines)
                {
                    tof.AddInline(inline);
                }

                TofItems.Add(tof);
            }

        }
    }
}
