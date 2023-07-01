
using System.Drawing;
/// <summary>
/// Useful lagacy class that wanted to be adapted
/// </summary>
public class LegacySquare
{
    public void Draw(int x1, int y1, int x2, int y2)
    {
        Console.WriteLine($"Drawing Coordinates ({x1},{y1}) , ({x1},{y2}) , ({x2},{y1}) , ({x2},{y2})  ");
    }
}




public interface IShape
{
    public void Draw(params Point[] points);

}



public class SquareAdapter : IShape
{
    private LegacySquare legacySquare;
    public SquareAdapter(LegacySquare square)
    {
        legacySquare = square;
    }
    public void Draw(params Point[] points)
    {
        legacySquare.Draw(points[0].X, points[0].Y, points[1].X, points[1].Y);
    }
}

