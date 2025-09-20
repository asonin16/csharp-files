namespace AnotherTest4;

class Program
{
    static void Main(string[] args)
    {
        string value = "102";
        // int result = 0;
        
        if (int.TryParse(value, out int result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }

        if (result > 0)
        {
            Console.WriteLine($"Measurement (w/ offset): {50 + result}");
        }
    }
}
