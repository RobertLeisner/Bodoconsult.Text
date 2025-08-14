// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using System;
using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;

namespace Bodoconsult.Text.Renderer.PlainText;

/// <summary>
/// Text rendering element for <see cref="Error"/> instances
/// </summary>
public class ErrorPlainTextRendererElement : ParagraphBasePlainTextRendererElement
{

    /// <summary>
    /// Default ctor
    /// </summary>
    public ErrorPlainTextRendererElement(Error error)
    {
        _paragraph = error;
        LeftRightBorderChar = "!";
        TopBottomBorderChar = "!";
    }
}