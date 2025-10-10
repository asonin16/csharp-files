namespace NewProject404;

class Program
{
    static void Main(string[] args)
    {
        var p1 = new Point(5, 2, "red");
        var l1 = new Line(0, 0, 8, 9, "white");
        var c1 = new Circle(0, 0, 23, "yellow");
        var c2 = new Circle(0, 0, 12, "green");

        var shapes = new Shape[] { p1, l1, c1, c2 };
        DrawScene(shapes);
    }
    static void DrawScene(Shape[] shapes)
    {
        foreach(var shape in shapes)
        {
            shape.Draw();
        }
    }
}
