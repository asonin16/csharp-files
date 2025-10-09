namespace NewProject404;

public class Shape(int X, int Y)
{
    public int X { get; set; } = X;
    public int Y { get; set; } = Y;

    // public Shape(int X, int Y)
    // {
    //     this.X = X;
    //     this.Y = Y;
    // }

    public virtual void Draw()
    {
        Console.WriteLine($"Shape: X = {X,2}, Y = {Y,2}");
    }
    
}
