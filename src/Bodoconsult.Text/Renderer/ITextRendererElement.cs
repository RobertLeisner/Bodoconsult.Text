// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

namespace Bodoconsult.Text.Renderer
{
    /// <summary>
    /// Interface for text rendering elements
    /// </summary>
    public interface ITextRendererElement
    {
        /// <summary>
        /// Render the element
        /// </summary>
        /// <param name="renderer">Current renderer</param>
        void RenderIt(ITextDocumentRender renderer);
    }
}
