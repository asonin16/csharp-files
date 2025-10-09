using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
