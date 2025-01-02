// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System.IO;
using Bodoconsult.Latex.Enums;

namespace Bodoconsult.Latex.Interfaces
{
    /// <summary>
    /// Interface for items holding image information for LaTex output
    /// </summary>
    public interface ILaTexImageItem : ILaTexItem
    {

        /// <summary>
        /// Indent level
        /// </summary>
        Stream ImageData { get; set; }


        /// <summary>
        /// Imge type
        /// </summary>
        LaTexImageType ImageType { get; set; } 

    }
}