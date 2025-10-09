namespace NewProject404;

public class Circle(int X1, int Y1, int radius) : Shape(X1, Y1)
{
    private int radius = radius;
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

    public override void Draw()
    {
        Console.WriteLine($"Circle: X = {X,2}, Y = {Y,2}, Radius = {Radius,2}");
    }

}
