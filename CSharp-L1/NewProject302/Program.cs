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
    public static double Average(int x, int y, int z) => (x + y + z) / 3.0;
    public static double Average(double x, double y) => (x + y) / 2.0;
    public static double Average(params int[] arr)
    {
        long sum = 0L;
        foreach (int k in arr)
            sum += k;
        return (double)sum / arr.LongLength;
    }
    public static int Increment(ref int input) => ++input;
    public static void TestMethod(in int a, out int b) => b = a * a;

    static void Main(string[] args)
    {
        var p = new Program();
        p.SayHello();

        SayHello2();
        SayHello3("Alexey", 54);
        SayHello3("Polina");
        SayHello3(age: 20);

        Console.WriteLine(Average(12, 45));
        Console.WriteLine(Average(12.67, 45.98));
        Console.WriteLine(Average(24, 43, 89));
        Console.WriteLine(Average(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

        int value = 23;
        Console.WriteLine(Increment(ref value));

        TestMethod(in value, out int result);
        Console.WriteLine(result);
    }
}
