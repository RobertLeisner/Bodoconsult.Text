// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.


using Bodoconsult.Latex.Converters;
using Bodoconsult.Latex.Interfaces;
using Bodoconsult.Latex.Model;
using Bodoconsult.Latex.Office.Analyzer;

namespace Bodoconsult.Latex.Services
{

    /// <summary>
    /// Convert a Powerpoint 2016 and 2019 presentation to LaTex
    /// </summary>
    public class Powerpoin2016PresentationConverterService : IPresentationConverterService
    {

        protected ILatexWriterService LatexWriterService;

        protected IPresentationToLaTexConverter Converter;

        protected IPresentationAnalyzer Analyzer;


        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="presentationJob"></param>
        public Powerpoin2016PresentationConverterService(PresentationJob presentationJob)
        {
            PresentationJob = presentationJob;

            LatexWriterService = new LatexV2WriterService(presentationJob.LaTexFilePath);

            Analyzer = new Powerpoint2016Analyzer(presentationJob.PresentationFilePath);

            Converter = new PresentationToLaTexConverter(Analyzer, LatexWriterService);


        }


        /// <summary>
        /// Current presentation job
        /// </summary>
        public PresentationJob PresentationJob { get; }



        /// <summary>
        /// Convert the presentation to LaTex
        /// </summary>
        public void ConvertPresentation()
        {
            Converter.Convert();
        }
    }
}
