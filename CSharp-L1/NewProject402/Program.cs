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
        p3.MoveBy(2, 2);
        p3.Draw();

        var l1 = new Line(5, 6, 10, 8);
        l1.Draw();
        l1.MoveBy(-2, -2);
        l1.Draw();

        var c1 = new Circle(0, 0, 4);
        c1.Draw();
        c1.MoveBy(3, 3);
        c1.Draw();
        c1.Scale(2.5);
        c1.Draw();
    }
}
