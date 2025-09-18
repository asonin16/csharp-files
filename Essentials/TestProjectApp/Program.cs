namespace TestProjectApp;

class Program
{
    static void Main(string[] args)
    {
        var (name, capital, population, gdpPerCapita) = ("Russia", "Moscow", 142_000_000.00M, 13000.00M);
        Console.WriteLine($"Country: {name},\nCapital: {capital},\nPopulation: {population},\nGDP per capita: {gdpPerCapita}.");
        char[] ch = ['A', 'B', 'C', 'D', 'E', 'F'];
        Console.WriteLine(string.Join("", ch[..].Reverse()));
    }
}
