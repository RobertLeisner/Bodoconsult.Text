namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Error"/> instances
/// </summary>
public class ErrorStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public ErrorStyle()
    {
        TagToUse = "ErrorStyle";
        Name = TagToUse;
    }
}