using MudBlazor;

namespace Boggle.Components.BoggleBoard;

public class Cell
{
    public string Letter { get; set; }
    public int Row { get; set; }
    public int Column { get; set; }
    public bool IsHighlighted { get; set; } = false;
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Row, Column);
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is Cell cell)
        {
            return cell.Row == Row && cell.Column == Column;
        }
        return false;
    }
}