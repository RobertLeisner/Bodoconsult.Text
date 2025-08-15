// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="List"/> instances
/// </summary>
public class ListPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{
  

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListPlainTextRendererElement(List list)
    {
        Paragraph = list;
    }

}