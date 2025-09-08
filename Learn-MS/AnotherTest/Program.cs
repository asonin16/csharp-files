namespace AnotherTest;

class Program
{
    static void Main(string[] args)
    {
        string text = "More than enough to say";
        var words = text.Split(" ");

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

        var names = new List<string> { "one", "two", "three", "four", "five" };

        foreach (var name in names)
        {
            Console.WriteLine($"{name}, lenght: {name.Length}, index: {names.IndexOf(name)}");
        }

        Console.WriteLine($"count(size) of the list: {names.Count}");
        Console.WriteLine($"capacity of the list: {names.Capacity}");

        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine(largerValue);

        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }
    }
}
