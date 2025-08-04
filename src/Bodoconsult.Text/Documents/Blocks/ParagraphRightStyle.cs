namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="ParagraphRight"/> instances
/// </summary>
public class ParagraphRightStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public ParagraphRightStyle()
    {
        TagToUse = "ParagraphRightStyle";
        Name = TagToUse;
        TextAlignment = TextAlignment.Justify;
    }
}