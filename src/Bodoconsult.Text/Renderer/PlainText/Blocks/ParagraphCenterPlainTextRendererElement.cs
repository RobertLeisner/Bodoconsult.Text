// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="ParagraphCenter"/> instances
/// </summary>
public class ParagraphCenterPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{

    /// <summary>
    /// Default ctor
    /// </summary>
    public ParagraphCenterPlainTextRendererElement(ParagraphCenter paragraphCenter)
    {
        _paragraph = paragraphCenter;
    }

}