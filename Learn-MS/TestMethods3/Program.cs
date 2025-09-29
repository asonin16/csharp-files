namespace TestMethods3;

class Program
{
    const double pi = 3.14159;
    static void Main(string[] args)
    {
        PrintCircleInfo(12);
        PrintCircleInfo(24);
            }

    static void PrintCircleInfo(int radius)
    {
        Console.WriteLine($"Circle with radius {radius}");
        PrintCircleArea(radius);
        PrintCircleCircumference(radius);
    }

    static void PrintCircleArea(int radius)
    {
        double area = pi * (radius * radius);
        Console.WriteLine($"Area = {area}");
    }

    static void PrintCircleCircumference(int radius)
    {
        double circumference = 2 * pi * radius;
        Console.WriteLine($"Circumference = {circumference}");
    }
}
