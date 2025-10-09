namespace NewProject402;

public class Point (int X, int Y)
{
    public int X { get; set; } = X;
    public int Y { get; set; } = Y;

    public void Draw()
    {
        Console.WriteLine($"Point: X = {X,2}, Y = {Y,2}");
    }
    
    public void MoveBy(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }
}
