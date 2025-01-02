// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System;
using Bodoconsult.Latex.Model;

namespace Bodoconsult.Latex.Interfaces
{

    /// <summary>
    /// Interface for presentation analyzers
    /// </summary>
    public interface IPresentationAnalyzer: IDisposable
    {

        /// <summary>
        /// Include hidden slides
        /// </summary>
        bool IncludeHiddenSlides { get; set; }


        /// <summary>
        /// Analyse the presentation
        /// </summary>
        PresentationMetaData Analyse();


        /// <summary>
        /// Current meta data of the presentation
        /// </summary>
        PresentationMetaData PresentationMetaData { get; }



    }
}