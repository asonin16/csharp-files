namespace CheckingForNull;

public class Program
{
    public static void Main(string[] args)
    {
        int? number = null;

        string? text = null;
        // string? text = "sample string";
        int? length = text?.Length;

        if (length is null)
        {
            Console.WriteLine("text was not created");
        }
        else
        {
            Console.WriteLine($"'text length' is {length}");
        }

        if (args.Length > 0)
        {
            number = args[0].Length;
        }

        if (number is null)
        {
            Console.WriteLine("'number' requires a value and cannot be null");
        }
        else
        {
            Console.WriteLine($"'number' doubled is {number * 2}.");
        }
    }
}
