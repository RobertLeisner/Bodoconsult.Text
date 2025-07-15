// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.Collections.Generic;
using System.IO;
using Bodoconsult.Latex.Enums;
using Bodoconsult.Latex.Interfaces;

namespace Bodoconsult.Latex.Model
{
    /// <summary>
    /// Paragraph class for image paragraphs
    /// </summary>
    public class ImageItem : ILaTexImageItem
    {

        /// <summary>
        /// Image legend text content
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Nested items
        /// </summary>
        public IList<ILaTexItem> SubItems { get; } = new List<ILaTexItem>();

        public int SortId { get; set; }
        public long ShapePosition { get; set; }


        /// <summary>
        /// Indent level
        /// </summary>
        public Stream ImageData { get; set; }



        /// <summary>
        /// Imge type
        /// </summary>
        public LaTexImageType ImageType { get; set; } = LaTexImageType.Jpg;
    }
}
