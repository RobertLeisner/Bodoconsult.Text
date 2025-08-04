namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="SectionSubtitle"/> instances
/// </summary>
public class SectionSubtitleStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionSubtitleStyle()
    {
        TagToUse = "SectionSubtitleStyle";
        Name = TagToUse;
        FontSize = Document.DefaultFontSize + 8;
        Margins.Top = Document.DefaultFontSize * 3;
    }
}