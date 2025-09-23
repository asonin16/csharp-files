namespace ProgrammingLanguages;

public class Program
{
    public static void Main()
    {
        var languages = new string[] {"C#", "COBOL", "Java", "C++", "TypeScript", "Swift", "Python", "Lisp", "JavaScript"};

        Array.Sort(languages);

        string searchString = "COBOL";
        int index = Array.BinarySearch(languages, searchString);

        Console.WriteLine("The wave of the future, "+ $"{ searchString }, is at index { index }.");

        Console.WriteLine();
        Console.WriteLine($"{ "First Element",-20 }\t{ "Last Element",-20 }");
        Console.WriteLine($"{ "-------------",-20 }\t{ "------------",-20 }");
        Console.WriteLine($"{ languages[0],-20 }\t{ languages[^1],-20 }");

        Array.Reverse(languages);

        Console.WriteLine($"{ languages[0],-20 }\t{ languages[^1],-20 }");
        // Note this does not remove all items from the array
        // Rather it sets each item to the type's default value

        Array.Clear(languages, 0, languages.Length);

        Console.WriteLine($"{ languages[0],-20 }\t{ languages[^1],-20 }");
        Console.WriteLine($"After clearing, the array size is: { languages.Length }");
    }
}
