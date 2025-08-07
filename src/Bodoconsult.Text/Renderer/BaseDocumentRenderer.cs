// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Linq;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
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

            var styleset = (Styleset)document.ChildBlocks.FirstOrDefault(x => x.GetType() == typeof(Styleset));

            // No styleset: apply default styleset
            if (styleset == null)
            {
                styleset = StylesetHelper.CreateDefaultStyleset();
                document.AddBlock(styleset);
            }

            PageStyleBase = (PageStyleBase)styleset.FindStyle("DocumentStyle");

        }

        /// <summary>
        /// The document to render
        /// </summary>
        public Document Document { get; }

        /// <summary>
        /// Current styleset
        /// </summary>
        public Styleset Styleset { get; set; }


        /// <summary>
        /// Current page settings to apply
        /// </summary>
        public PageStyleBase PageStyleBase { get; set; }

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
