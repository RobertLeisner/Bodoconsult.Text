// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System.Collections.Generic;

namespace Bodoconsult.Text.Documents
{
    /// <summary>
    /// Calculate TOC, TOF and TOE content for a LDML document
    /// </summary>
    public class LdmlCalculator
    {

        private string _equationPrefix = "Equation";
        private string _figurePrefix = "Figure";

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="document">Current document to calculate</param>
        public LdmlCalculator(Document document)
        {
            Document = document;

            // ToDo: load prefeices for equations and figures from document meta data
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
        /// Current figure counter
        /// </summary>
        public int FigurCounter { get; private set; }

        /// <summary>
        /// All equations in the document to count
        /// </summary>
        public List<Equation> Equations { get; } = new();

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
                foreach (var block in section.ChildBlocks)
                {
                    if (block is not Equation equation)
                    {
                        continue;
                    }

                    EquationCounter++;

                    equation.TagName = $"Equation{EquationCounter}";
                    equation.CurrentPrefix = $"{_equationPrefix} {EquationCounter}:";

                    Equations.Add(equation);
                }
            }
        }

        /// <summary>
        /// Enumerate all items needed for TOF
        /// </summary>
        public void EnumerateAllItemsForTof()
        {


        }

    }
}
