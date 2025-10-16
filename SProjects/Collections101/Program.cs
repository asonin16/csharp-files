using System.Collections;

namespace Collections101;

internal class Program
{
    static void Main()
    {
        // Example: Adding, removing, and iterating through a List<T>

        // Define the type T as string for this list
        var books = new List<string>(); // T is string
        books.Add("Book A"); // Add a string to the list
        books.Add("Book B");
        books.Add("Book C");
        books.Remove("Book A"); // Remove a specific string from the list

        foreach (string book in books) // Iterate through the list
        {
            Console.Write($"{book} ");
        }
        Console.WriteLine();

        // Expected output:
        // Book B
        // Book C

        var numbers = new ArrayList() { 123, 456, 789, 900, 500 };

        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();

        numbers.Sort();

        foreach (var number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();

        var names = new ArrayList() { "Tanya", "Alice", "Maria" };

        foreach (var name in names)
        {
            Console.Write($"{name} ");
        }
        Console.WriteLine();

        names.Sort();

        foreach (var name in names)
        {
            Console.Write($"{name} ");
        }
        Console.WriteLine();
    }
}
