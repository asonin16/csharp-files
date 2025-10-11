namespace NewProject506;

internal class Program
{
    static void Main(string[] args)
    {
        var ros1 = new ReadOnlyStorage<int>(5);
        var ros2 = new ReadOnlyStorage<double>(2.5);
        var ros3 = new ReadOnlyStorage<string>("abc");
        Console.WriteLine(ros1.Data * 2);
        Console.WriteLine(ros2.Data * 2);
        Console.WriteLine(ros3.Data + "!");
        Console.WriteLine(ros1.IsGreater(2));
    }
}
