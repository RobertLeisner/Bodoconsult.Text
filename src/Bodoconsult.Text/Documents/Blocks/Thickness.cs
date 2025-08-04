using System.Text;

namespace Bodoconsult.Text.Documents;

/// <summary>
/// Thickness definition for margins and 
/// </summary>
public class Thickness:  DocumentElement
{
    /// <summary>
    /// Default ctor
    /// </summary>
    public Thickness()
    {
        
    }

    /// <summary>
    /// Ctor with thickness values provided for left, top, right and bottom
    /// </summary>
    /// <param name="left">Left thickness in pt</param>
    /// <param name="top">Top thickness in pt</param>
    /// <param name="right">Right thickness in cm</param>
    /// <param name="bottom">Bottom thickness in pt</param>
    public Thickness(double left, double top, double right, double bottom)
    {
        Left = left;
        Right = right;
        Top = top;
        Bottom = bottom;
    }

    /// <summary>
    /// Ctor with a uniform value provided for left, top, right and bottom
    /// </summary>
    /// <param name="uniformValue"></param>
    public Thickness(double uniformValue)
    {
        Left = uniformValue;
        Right = uniformValue;
        Top = uniformValue;
        Bottom = uniformValue;
    }

    /// <summary>
    /// Left thickness in pt
    /// </summary>
    public double Left { get; set; }

    /// <summary>
    /// Top thickness in pt
    /// </summary>
    public double Top { get; set; } = Document.DefaultFontSize * 0.5;

    /// <summary>
    /// Right thickness in pt
    /// </summary>
    public double Right { get; set; }

    /// <summary>
    /// Bottom thickness in pt
    /// </summary>
    public double Bottom { get; set; }

    /// <summary>
    /// Add the current element to a document defined in LDML (Logical document markup language)
    /// </summary>
    /// <param name="document">StringBuilder instance to create the LDML in</param>
    /// <param name="indent">Current indent</param>
    public override void ToLdmlString(StringBuilder document, string indent)
    {
        document.Append($"{Left},{Top},{Right},{Bottom}");
    }
}