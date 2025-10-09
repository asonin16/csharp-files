using System.Security.Cryptography;

namespace NewProject402;

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Point(5, 6);
        var p2 = new Point(10, 8);
        var p3 = new Point(0, 0);

        p1.Draw();
        p2.Draw();
        p3.Draw();

        var l1 = new Line(p1, p2);

        var c1 = new Circle(0, 0, 4);
    }
}
