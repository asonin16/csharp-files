namespace NewProject404;

class Program
{
    static void Main(string[] args)
    {
        var s1 = new Shape(3, 4);
        var p1 = new Point(5, 2);
        var l1 = new Line(0, 0, 8, 9);
        var c1 = new Circle(0, 0, 23);
        var c2 = new Circle(0, 0, -12);

        var shapes = new Shape[] { s1, p1, l1, c1, c2 };
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
