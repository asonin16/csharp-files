using System.Collections;

namespace HashTable102;

internal class Program
{
    static void Main(string[] args)
    {
        Hashtable phoneBook = new()
        {
            { "Marcin", "101-202-303" },
            { "John", "202-303-404" }
        };
        phoneBook["Aline"] = "303-404-505";
        phoneBook["Maria"] = "404-505-606";
        phoneBook["Aline"] = "505-606-707";

        Console.WriteLine("Phone numbers:");
        if (phoneBook.Count == 0)
        {
            Console.WriteLine("Empty list.");
        }
        foreach (DictionaryEntry entry in phoneBook)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        Console.Write("\nSearch by name: ");
        string name = Console.ReadLine() ?? string.Empty;
        if (phoneBook.ContainsKey(name))
        {
            string number = (string)phoneBook[name]!;
            Console.WriteLine($"Phone number: {number}");
        }
        else
        {
            Console.WriteLine("Does not exist.");
        }
    }
}
