namespace NewProject404;

public class Point : Shape
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y, string color)
    : base(color)
    {
        X = x;
        Y = y;
    }
    
    public override void Draw()
    {
        Console.WriteLine($"Point: X = {X,2}, Y = {Y,2}, Color = {Color}");
    }

}
