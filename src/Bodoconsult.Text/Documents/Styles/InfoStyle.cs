namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Info"/> instances
/// </summary>
public class InfoStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public InfoStyle()
    {
        TagToUse = "InfoStyle";
        Name = TagToUse;
        BorderBrush = new SolidColorBrush(Document.DefaultColor);
        BorderThickness.Bottom = Document.DefaultBorderWidth;
        BorderThickness.Left =   Document.DefaultBorderWidth;
        BorderThickness.Right = Document.DefaultBorderWidth;
        BorderThickness.Top = Document.DefaultBorderWidth;
        Paddings.Left = Document.DefaultPaddingWidth;
        Paddings.Right = Document.DefaultPaddingWidth;
        Paddings.Top = Document.DefaultPaddingWidth;
        Paddings.Bottom = Document.DefaultPaddingWidth;
        Margins.Top = 3 * Document.DefaultPaddingWidth;
        Margins.Bottom = 3 * Document.DefaultPaddingWidth;
    }
}