namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Warning"/> instances
/// </summary>
public class WarningStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public WarningStyle()
    {
        TagToUse = "WarningStyle";
        Name = TagToUse;
    }
}