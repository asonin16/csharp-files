namespace AnotherTest5;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        string message = "";
        float total = 0;

        foreach (var value in values)
        {
            if (float.TryParse(value, out float result))
            {
                total += result;
            }
            else
            {
                message += value;
            }
        }

        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");
    }
}
