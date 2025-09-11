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

            Styleset = (Styleset)document.ChildBlocks.FirstOrDefault(x => x.GetType() == typeof(Styleset));

            // No styleset: apply default styleset
            if (Styleset == null)
            {
                Styleset = StylesetHelper.CreateDefaultStyleset();
                document.AddBlock(Styleset);
            }

            PageStyleBase = (PageStyleBase)Styleset.FindStyle("DocumentStyle");

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
