namespace NewProject202;

record struct Coords3D(int X, int Y, int Z);

record class Point3D(int X, int Y, int Z, string Color);

class Program
{
    static void Main(string[] args)
    {
        var c1 = new Coords3D(1, 2, 3);
        var c2 = new Coords3D(1, 2, 3);
        var c3 = c1;
        Console.WriteLine($"c1 = {c1}");
        Console.WriteLine(c1 == c2);
        Console.WriteLine(c1 == c3);

        var p1 = new Point3D(1, 2, 3, "black");
        var p2 = new Point3D(1, 2, 3, "black");
        var p3 = p1;
        Console.WriteLine($"p1 = {p1}");
        Console.WriteLine(p1 == p2);
        Console.WriteLine(p1 == p3);
    }
}
