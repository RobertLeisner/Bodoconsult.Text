// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Interfaces;

namespace Bodoconsult.Text.Renderer
{
    /// <summary>
    /// Base implementation of a <see cref="IDocumentRenderer"/>
    /// </summary>
    public class BaseDocumentRenderer : IDocumentRenderer
    {

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="document">Document to render</param>
        public BaseDocumentRenderer(Document document)
        {
            Document = document;
        }

        /// <summary>
        /// The document to render
        /// </summary>
        public Document Document { get; }

        /// <summary>
        /// Prepare the document for rendering: calculate toc, figure counters
        /// </summary>
        public void PrepareDocument()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Render the document
        /// </summary>
        public virtual void RenderIt()
        {
            throw new NotSupportedException("Create an overload for this method");
        }


        /// <summary>
        /// Save the rendered document as file
        /// </summary>
        /// <param name="fileName">Full file path. Existing file will be overwritten</param>
        public virtual void SaveAsFile(string fileName)
        {
            throw new NotSupportedException("Create an overload for this method");
        }
    }
}
