namespace NewProject302;

class Program
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
    public static void SayHello2()
    {
        Console.WriteLine("Hello!");
    }
    public static void SayHello3(string name = "Stranger", int age = 18)
    {
        Console.WriteLine($"Hello, {name} - {age}!");
    }
    public static double Average(int x, int y)
    {
        return (x + y) / 2.0;
    }
    public static double Average(double x, double y) => (x + y) / 2.0;
    static void Main(string[] args)
    {
        var p = new Program();
        p.SayHello();

        SayHello2();
        SayHello3("Alexey", 54);
        SayHello3("Polina");
        SayHello3(age: 20);

        Console.WriteLine(Average(12, 45));
    }
}
