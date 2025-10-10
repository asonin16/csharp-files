namespace NewProject404;

public class Circle : Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    private int radius;
    public int Radius
    {
        get { return radius; }
        set
        {
            if (value < 0)
            {
                throw new Exception();
            }
            radius = value;
        }
    }

    public Circle(int x, int y, int radius, string color)
    : base(color)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Circle: X = {X,2}, Y = {Y,2}, Radius = {Radius,2}, Color = {Color}");
    }

}
