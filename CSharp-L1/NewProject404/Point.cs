namespace NewProject404;

public class Point : Shape
{
    public Point(int X1, int Y1)
        : base(X1, Y1)
    {

    }

    public override void Draw()
    {
        Console.WriteLine($"Point: X = {X,2}, Y = {Y,2}");
    }

}
