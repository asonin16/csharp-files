namespace NewProject404;

public class Circle : Shape
{
    public int Radius { get; set; }
    
    // private int radius = radius;
    // public int Radius
    // {
    //     get { return radius; }
    //     set
    //     {
    //         if (value < 0)
    //         {
    //             throw new Exception();
    //         }
    //         radius = value;
    //     }
    // }

    public Circle(int X1, int Y1, int Radius)
        : base(X1, Y1)
    {
        this.Radius = Radius;
    }

    

    public override void Draw()
    {
        Console.WriteLine($"Circle: X = {X,2}, Y = {Y,2}, Radius = {Radius,2}");
    }

}
