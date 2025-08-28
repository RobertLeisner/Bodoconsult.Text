// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System;
using System.Text;

namespace Bodoconsult.Text.Renderer.Rtf.Blocks;

/// <summary>
/// Rtf rendering element for <see cref="List"/> instances
/// </summary>
public class ListRtfTextRendererElement : RtfTextRendererElementBase
{
    private readonly List _list;

    /// <summary>
    /// Default ctor
    /// </summary>
    public ListRtfTextRendererElement(List list) : base(list)
    {
        _list = list;
        ClassName = list.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        
    }
}