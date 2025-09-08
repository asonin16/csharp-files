namespace TestBench02;

class Program
{
    static void Main(string[] args)
    {
        // Outputs the current line terminator.
        // By default, this is a carriage-return and line feed.
        Console.WriteLine();
        // Outputs the greeting and the current line terminator.
        Console.WriteLine("Hello Ahmed");
        // Outputs a formatted number and date and the current line terminator.
        Console.WriteLine(
        "Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);

        // Let the heightInMetres variable become equal to the value 1.88.
        double heightInMetres = 1.88;
        Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string grinningEmoji = char.ConvertFromUtf32(0x1F600);
        Console.WriteLine(grinningEmoji);
    }
}
