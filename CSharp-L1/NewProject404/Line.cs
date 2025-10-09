using System;

namespace NewProject404;

public class Line(int X1, int Y1, int X2, int Y2) : Shape(X1, Y1)
{
    public int X2 { get; set; } = X2;
    public int Y2 { get; set; } = Y2;

    public override void Draw()
    {
        Console.WriteLine($"Line: X1 = {X,2}, Y1 = {Y,2}, X2 = {X2,2}, Y2 = {Y2,2}");
    }
        
}
