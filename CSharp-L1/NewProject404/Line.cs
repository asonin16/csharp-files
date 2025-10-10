namespace NewProject404;

public class Line : Shape
{
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }

    public Line(int x1, int y1, int x2, int y2, string color)
        : base(color)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y1 = Y2;
    }

    public override void Draw()
    {
        Console.WriteLine($"Line: X1 = {X1,2}, Y1 = {Y1,2}, X2 = {X2,2}, Y2 = {Y2,2}, Color = {Color}");
    }
        
}
