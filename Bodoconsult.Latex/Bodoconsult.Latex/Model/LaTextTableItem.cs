﻿// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.Collections.Generic;
using Bodoconsult.Latex.Interfaces;

namespace Bodoconsult.Latex.Model
{
    public class LaTextTableItem : ILaTexTableItem
    {
        /// <summary>
        /// Holds the text for the LaTex output
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Nested items
        /// </summary>
        public IList<ILaTexItem> SubItems { get; } = new List<ILaTexItem>();

        /// <summary>
        /// The sort order id the items follow up
        /// </summary>
        public int SortId { get; set; }

        /// <summary>
        /// The shape position of surrounding shape
        /// </summary>
        public long ShapePosition { get; set; }


        public string[,] TableData { get; set; }
    }
}