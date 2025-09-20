namespace AnotherTest4;

class Program
{
    static void Main(string[] args)
    {
        string value = "102";
        if (int.TryParse(value, out int result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }
        Console.WriteLine($"Measurement (w/ offset): {50 + result}");
    }
}
