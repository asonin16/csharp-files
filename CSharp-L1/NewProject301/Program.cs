namespace NewProject301;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"i = {i}");
        }
        Console.WriteLine();

        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                Console.Write("{0, -4}", i * j);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int a = 2;
        while (a < 1000)
        {
            Console.WriteLine(a);
            a *= 2;
        }
        Console.WriteLine();

        a = 2;
        do
        {
            Console.WriteLine(a);
            a *= 2;
        } while (a < 1000);
        Console.WriteLine();

        string[] names = ["Alexey", "Alice", "Maria", "Tatiana"];
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();

        IList<string> names2 = new List<string>() { "Alexey", "Alice", "Maria", "Tatiana" };
        names2.Add("Polina");
        foreach (var name in names2)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();

        ICollection<string> names3 = new List<string>() { "Alexey", "Alice", "Maria", "Tatiana", "Maria"};
        IEnumerator<string> en = names3.GetEnumerator();
        while (en.MoveNext())
        {
            string name = en.Current;
            Console.WriteLine(name);
        }
        Console.WriteLine();

        var results = names3.Distinct().ToList();
        foreach (var name in results)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();
    }
}
