// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using System;
using System.Text;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Interfaces;
using Bodoconsult.Text.Pdf.Interfaces;

namespace Bodoconsult.Text.Pdf.Renderer.Inlines;

/// <summary>
/// Base class to render <see cref="Inline"/> elements to HTML
/// </summary>
public class InlinePdfTextRendererElementBase : IPdfTextRendererElement
{
    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public void RenderIt(ITextDocumentRenderer renderer)
    {
        // do nothing
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="renderer"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void RenderIt(PdfTextDocumentRenderer renderer)
    {
        throw new NotSupportedException("Override method RenderToString() in derived subclasses");
    }

    /// <summary>
    /// Render the inline element to string
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    /// <param name="sb">String to add the inline element rendered</param>
    public virtual void RenderToString(ITextDocumentRenderer renderer, StringBuilder sb)
    {
        throw new NotSupportedException("Override method RenderToString() in derived subclasses");
    }
}