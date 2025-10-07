namespace NewProject201;

enum Colors { Red = 100, Green, Blue };

enum BColors : byte { Cyan, Magenta, Yello };

struct Point(int x, int y)
{
    public int x = x, y = y;

    public void MoveBy(int dx, int dy)
    {
        x += dx;
        y += dy;
    }
};

ref struct Point2(int x, int y) // only in stack with a lot of limitations
{
    public int x = x, y = y;
};

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Point(10, 12);

        // int @int = 7; OK
        short a = 1, b = 3;
        var c = 0f;
        a = (short)((float)b / c);
        // const double alfa = 30; OK
        int count = default;
        Console.WriteLine(a);
        Console.WriteLine(c);
        Console.WriteLine(count);

        int x = int.MaxValue;
        int y = 1;
        Console.WriteLine(x);
        Console.WriteLine(x + (long)y);

        int? abc = null;
        Console.WriteLine(abc.HasValue);
        abc = 123456;
        if (abc.HasValue) // a != null
        {
            int def = abc.Value;
            Console.WriteLine(def);
        }

        // decimal? xyz = 123.45m; OK
    }
}
