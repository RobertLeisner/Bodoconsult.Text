// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Interfaces;

/// <summary>
/// Interface for rendering <see cref="Document"/> instances
/// </summary>
public interface IDocumentRenderer
{
    /// <summary>
    /// The document to render
    /// </summary>
    Document Document { get; }

    /// <summary>
    /// Prepare the document for rendering: calculate toc, figure counters
    /// </summary>
    void PrepareDocument();

    /// <summary>
    /// Render the document
    /// </summary>
    void RenderIt();


    /// <summary>
    /// Save the rendered document as file
    /// </summary>
    /// <param name="fileName">Full file path. Existing file will be overwritten</param>
    void SaveAsFile(string fileName);
}