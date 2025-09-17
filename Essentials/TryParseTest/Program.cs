namespace TryParseTest;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        string? input;

        Console.Clear();
        Console.Write("Enter a number: ");
        input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            Console.WriteLine($"'input' was parsed successfully to {number}");
        }
        else
        {
            Console.WriteLine("The text entered was not a valid number.");
        }

        Console.WriteLine($"'number' currently has the value: {number}");
    }
}
#endregion INCLUDE
