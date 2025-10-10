namespace NewProject404;

public abstract class Shape
{
    public string Color { get; set; }
    // public int X { get; set; } = X;
    // public int Y { get; set; } = Y;

    public const string DEF_COL = "black";
    public Shape(string color = DEF_COL)
    {
        Color = color;
    }

    // public Shape(int X, int Y)
    // {
    //     this.X = X;
    //     this.Y = Y;
    // }

    public virtual void Draw() { }
    // {
    //     Console.WriteLine($"Shape: X = {X,2}, Y = {Y,2}");
    // }
    
    // public abstract void Draw();  // must be in abstract class
    
}
