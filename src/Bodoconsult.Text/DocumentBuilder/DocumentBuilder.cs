// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bodoconsult.Text.Interfaces;

namespace Bodoconsult.Text.DocumentBuilder
{
    public class DocumentBuilder: IDocumentBuilder
    {

        public DocumentBuilder(IDocumentFactory _documentFactory, IDocumentRenderer _documentRenderer)
        {
            DocumentFactory = _documentFactory;
            DocumentRenderer = _documentRenderer;
        }

        /// <summary>
        /// Current document factory
        /// </summary>
        public IDocumentFactory DocumentFactory { get; }

        /// <summary>
        /// The document renderer instance to use
        /// </summary>
        public IDocumentRenderer DocumentRenderer { get; }
    }

    internal interface IDocumentBuilder
    {
        /// <summary>
        /// Current document factory
        /// </summary>
        public IDocumentFactory DocumentFactory { get; }

        /// <summary>
        /// The document renderer instance to use
        /// </summary>
        public IDocumentRenderer DocumentRenderer { get;  }

    }
}
