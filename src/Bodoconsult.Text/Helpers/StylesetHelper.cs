// Copyright (c) Bodoconsult EDV-Dienstleistungen GmbH.  All rights reserved.

using Bodoconsult.Text.Documents;

namespace Bodoconsult.Text.Helpers;

/// <summary>
/// Helper class to generate <see cref="Styleset"/> instances
/// </summary>
public static class StylesetHelper
{
    /// <summary>
    ///  Create a default style set
    /// </summary>
    /// <returns></returns>
    public static Styleset CreateDefaultStyleset()
    {
        var styleset = new Styleset
        {
            Name = "Default"
        };

        // Add document style
        styleset.AddBlock(new DocumentStyle());
        styleset.AddBlock(new SectionStyle());

        // Add block styles
        styleset.AddBlock(new ParagraphStyle());


        return styleset;



    }

}