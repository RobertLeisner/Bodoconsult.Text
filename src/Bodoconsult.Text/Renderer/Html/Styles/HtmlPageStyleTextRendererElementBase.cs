// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Renderer.Html.Styles;

/// <summary>
/// Base class for <see cref="PageStyleBase"/> based styles
/// </summary>
public class HtmlPageStyleTextRendererElementBase
{

    /// <summary>
    /// Current block to renderer
    /// </summary>
    public PageStyleBase Style { get; private set; }
    /// <summary>
    /// CSS class name
    /// </summary>
    public string ClassName { get; protected set; }

    /// <summary>
    /// Default ctor
    /// </summary>
    /// <param name="style">Current page style</param>
    public HtmlPageStyleTextRendererElementBase(PageStyleBase style)
    {
        Style = style;
    }

}