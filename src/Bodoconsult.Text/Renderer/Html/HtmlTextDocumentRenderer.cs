// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// Render a <see cref="Document"/> to a plain UTF-8 text file
/// </summary>
public class HtmlTextDocumentRenderer : BaseTextDocumentRenderer
{
    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="document">Document to render</param>
    public HtmlTextDocumentRenderer(Document document) : base(document)
    { }
}