namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Table"/> instances
/// </summary>
public class TableHeaderCenterStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public TableHeaderCenterStyle()
    {
        TagToUse = "TableHeaderCenterStyle";
        Name = TagToUse;
        Bold = true;
        BorderBrush = new SolidColorBrush(Colors.Black);
        BorderThickness = new Thickness(1.0, 1.0, 1.0, 1.0);
        Paddings = new Thickness(Document.DefaultTablePaddingWidth);
        TextAlignment = TextAlignment.Center;
    }
}