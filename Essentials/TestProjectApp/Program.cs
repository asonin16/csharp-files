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

        string s1 = "First sample";
        IEnumerator rator = s1.GetEnumerator();
        while (rator.MoveNext())
        {
            char c = (char)rator.Current;
            Console.Write(c + ".");
        }
        Console.WriteLine();

        string s2 = "Second one";
        foreach (char c in s2)
        {
            Console.Write(c + ".");
        }
        Console.WriteLine();

        string[] names = ["Tom", "Dick", "Harry", "Mary", "Jay"];
        IEnumerable<string> query = names
            .Where(n => n.Contains('a'))
            .OrderBy(n => n.Length)
            .Select(n => n.ToUpper());
        foreach (string name2 in query)
        {
            Console.WriteLine(name2);
        }

        HashSet<string> set1 = ["one", "two", "three", "four", "five"];
        HashSet<string> set2 = ["four", "five", "six", "seven", "eight"];
        set1.UnionWith(set2);
        foreach (string str in set1)
        {
             Console.WriteLine(str);
        }
    }
}
