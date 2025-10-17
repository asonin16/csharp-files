namespace EnumStructRecords103;

public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

// public struct Point
// {
//     public int X;
//     public int Y;

//     public Point(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }
// }

public struct Rectangle
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public int Area => width * height;
}

public readonly struct ImmutablePoint
{
    public int X { get; init; }
    public int Y { get; init; }

    public ImmutablePoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}

internal class Program
{
    static void Main()
    {
        var point = new Point { X = 10, Y = 20 };
    }
}
