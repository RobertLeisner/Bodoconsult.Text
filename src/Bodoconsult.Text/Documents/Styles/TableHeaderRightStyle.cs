namespace Bodoconsult.Text.Documents;

/// <summary>
/// Style for <see cref="Table"/> instances
/// </summary>
public class TableHeaderRightStyle : ParagraphStyleBase
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public TableHeaderRightStyle()
    {
        TagToUse = "TableHeaderRightStyle";
        Name = TagToUse;
        Bold = true;
        BorderBrush = new SolidColorBrush(Colors.Black);
        BorderThickness = new Thickness(1.0, 1.0, 1.0, 1.0);
        Paddings = new Thickness(Styleset.DefaultTablePaddingWidth);
        TextAlignment = TextAlignment.Right;
    }
}