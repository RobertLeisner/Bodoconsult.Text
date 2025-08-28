// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH. All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Rtf.Styles;

/// <summary>
/// Rtf rendering element for <see cref="CodeStyle"/> instances
/// </summary>
public class CodeStyleRtfTextRendererElement : RtfParagraphStyleTextRendererElementBase
{
    private readonly ParagraphStyleBase _codeStyle;

    /// <summary>
    /// Default ctor
    /// </summary>
    public CodeStyleRtfTextRendererElement(CodeStyle codeStyle) : base(codeStyle)
    {
        _codeStyle = codeStyle;
        ClassName = "CodeStyle";
    }
}