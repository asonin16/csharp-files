using System.Collections;

namespace TestProjectApp;

class Program
{
    static void Main(string[] args)
    {
        var (name, capital, population, gdpPerCapita) = ("Russia", "Moscow", 142_000_000.00M, 13000.00M);
        Console.WriteLine($"Country: {name},\nCapital: {capital},\nPopulation: {population},\nGDP per capita: {gdpPerCapita}.");
        
        char[] ch = ['A', 'B', 'C', 'D', 'E', 'F'];
        Console.WriteLine(new string(ch[..]));
        Console.WriteLine(string.Join("", ch[..].Reverse()));

        string s = "Hello, CSharp";

        IEnumerator rator = s.GetEnumerator();
        while (rator.MoveNext())
        {
            char c = (char)rator.Current;
            Console.Write(c + ".");
        }

        Console.WriteLine();

        foreach (char c in s)
            Console.Write(c + ".");

        Console.WriteLine();

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        IEnumerable<string> query = names
            .Where (n => n.Contains('a'))
            .OrderBy (n => n.Length)
            .Select (n => n.ToUpper());
        foreach (string name2 in query)
            Console.WriteLine (name2);
    }
}
