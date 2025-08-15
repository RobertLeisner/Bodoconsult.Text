// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html.Styles;

/// <summary>
/// Base class for <see cref="ParagraphStyleBase"/> based styles
/// </summary>
public class HtmlParagraphStyleTextRendererElementBase
{

    /// <summary>
    /// Current block to renderer
    /// </summary>
    public ParagraphStyleBase Style { get; private set; }
    /// <summary>
    /// CSS class name
    /// </summary>
    public string ClassName { get; protected set; }

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="style">Current paragraph style</param>
    public HtmlParagraphStyleTextRendererElementBase(ParagraphStyleBase style)
    {
        Style = style;
    }

}