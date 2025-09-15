// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;
using Bodoconsult.Text.Helpers;
using System.Text;

namespace Bodoconsult.Text.Renderer.Html;

/// <summary>
/// HTML rendering element for <see cref="TotSection"/> instances
/// </summary>
public class TotSectionHtmlTextRendererElement : HtmlTextRendererElementBase
{
    private readonly TotSection _totSection;

    /// <summary>
    /// Default ctor
    /// </summary>
    public TotSectionHtmlTextRendererElement(TotSection totSection) : base(totSection)
    {
        _totSection = totSection;
        ClassName = totSection.StyleName;
    }

    /// <summary>
    /// Render the element
    /// </summary>
    /// <param name="renderer">Current renderer</param>
    public override void RenderIt(ITextDocumentRender renderer)
    {
        if (_totSection.ChildBlocks.Count == 0)
        {
            return;
        }

        // Get the content of all inlines as string
        var sb = new StringBuilder();

        renderer.Content.AppendLine($"<p class=\"TotHeadingStyle\">{renderer.CheckContent(renderer.Document.DocumentMetaData.TotHeading)}</p>");

        DocumentRendererHelper.RenderBlockChildsToHtml(renderer, sb, _totSection.ChildBlocks);

        // DocumentRendererHelper.RenderInlineChildsToPlainText(renderer, sb, _tofSection.ChildInlines, string.Empty, true);
        renderer.Content.Append(sb);
    }
}