using System.Security.Cryptography.X509Certificates;

namespace NewProject402;

public class Line(int X1, int Y1, int X2, int Y2)
{
    public int X1 { get; set; } = X1;
    public int Y1 { get; set; } = Y1;
    public int X2 { get; set; } = X2;
    public int Y2 { get; set; } = Y2;

    public void Draw()
    {
        Console.WriteLine($"Line: X1 = {X1,2}, Y1 = {Y1,2}, X2 = {X2,2}, Y2 = {Y2,2}");
    }

    public void MoveBy(int dx, int dy)
    {
        X1 += dx;
        Y1 += dy;
        X2 += dx;
        Y2 += dy;
    }

}
