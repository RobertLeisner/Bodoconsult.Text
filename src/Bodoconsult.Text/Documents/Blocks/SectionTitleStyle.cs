namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="SectionTitle"/> instances
/// </summary>
public class SectionTitleStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public SectionTitleStyle()
    {
        TagToUse = "SectionTitleStyle";
        Name = TagToUse;
    }
}