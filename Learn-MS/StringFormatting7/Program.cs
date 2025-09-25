namespace StringFormatting7;

class Program
{
    static void Main()
    {
        string message1 = "Hello, world!";
        char[] charsToFind1 = { 'a', 'e', 'i' };

        int index1 = message1.IndexOfAny(charsToFind1);
        Console.WriteLine($"Found '{message1[index1]}' in '{message1}' at index: {index1}.");

        string message2 = "Help (find) the {opening symbols}";
        Console.WriteLine($"Searching THIS Message: {message2}");
        char[] openSymbols2 = { '[', '{', '(' };
        int startPosition2 = 5;

        int openingPosition2 = message2.IndexOfAny(openSymbols2);
        Console.WriteLine($"Found WITHOUT using startPosition: {message2.Substring(openingPosition2)}");
        
        openingPosition2 = message2.IndexOfAny(openSymbols2, startPosition2);
        Console.WriteLine($"Found WITH using startPosition {startPosition2}:  {message2.Substring(openingPosition2)}");
    }
}
