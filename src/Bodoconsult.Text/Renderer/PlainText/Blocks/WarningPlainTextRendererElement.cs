// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Warning"/> instances
/// </summary>
public class WarningPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{


    /// <summary>
    /// Default ctor
    /// </summary>
    public WarningPlainTextRendererElement(Warning warning)
    {
        _paragraph= warning;
        LeftRightBorderChar = "?";
        TopBottomBorderChar = "?";
    }
}