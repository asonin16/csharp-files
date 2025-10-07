namespace NewProject203;

enum Geometry { Square, Circle, Triangle, Quadrant, Rectangle};

struct Point(int x, int y)
{
    public int x = x, y = y;
    public override string ToString()
    {
        return $"(x: {x}, y: {y})";
    }
};

struct Circle(Point center, int radius)
{
    public Point c = center;
    public int r = radius;
    public override string ToString()
    {
        return $"c: {c}, r: {r}";
    }
}

struct Line(Point p1, Point p2)
{
    public Point p1 = p1, p2 = p2;
        public override string ToString()
    {
        return $"p1: {p1}, p2: {p2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Point(2, 5);
        Console.WriteLine(p1.ToString());

        var c1 = new Circle(p1, 5);
        Console.WriteLine(c1.ToString());

        var p2 = new Point(7, 9);
        var p3 = new Point(22, 12);
        var l1 = new Line(p2, p3);
        Console.WriteLine(l1.ToString());
    }
}
