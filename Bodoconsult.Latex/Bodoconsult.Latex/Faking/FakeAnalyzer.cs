// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using System;
using Bodoconsult.Latex.Interfaces;
using Bodoconsult.Latex.Model;

namespace Bodoconsult.Latex.Faking
{
    /// <summary>
    /// Fake implementation of a presentation analyzer
    /// </summary>
    public class FakeAnalyzer: IPresentationAnalyzer
    {

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="metaData"></param>
        public FakeAnalyzer(PresentationMetaData metaData)
        {
            PresentationMetaData = metaData;
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Include hidden slides
        /// </summary>
        public bool IncludeHiddenSlides { get; set; }

        /// <summary>
        /// Analyse the presentation
        /// </summary>
        public PresentationMetaData Analyse()
        {
            return PresentationMetaData;
        }

        /// <summary>
        /// Current meta data of the presentation
        /// </summary>
        public PresentationMetaData PresentationMetaData { get; }
    }
}
