namespace NewProject402;

public class Circle(int X, int Y, int radius)
{
    public int X { get; set; } = X;
    public int Y { get; set; } = Y;

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

    public void Draw()
    {
        Console.WriteLine($"Circle: X = {X,2}, Y = {Y,2}, Radius = {Radius,2}");
    }

    public void MoveBy(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }

    public void Scale(double factor)
    {
        Radius = (int)Math.Round(Radius * factor);
    }
}
