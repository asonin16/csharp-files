using System;

namespace NewProject404;

public class Line : Shape
{
    public int X2 { get; set; }
    public int Y2 { get; set; }
    public Line(int X1, int Y1, int X2, int Y2)
        : base(X1, Y1)
    {
        this.X2 = X2;
        this.Y2 = Y2;
    }

    public override void Draw()
    {
        Console.WriteLine($"Line: X1 = {X,2}, Y1 = {Y,2}, X2 = {X2,2}, Y2 = {Y2,2}");
    }
        
}
