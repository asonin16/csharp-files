namespace NewProject204;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            var random = new Random();
            int n = random.Next(-10, 10);
            if (n > 0)
            {
                Console.WriteLine($"{n} > 0");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} < 0");
            }
            else
            {
                Console.WriteLine($"{n} = 0");
            }
        }

        string? name = null;
        Console.WriteLine(name?.ToUpper());

        string? text1 = name ?? "no name";
        name ??= "no name";
        string? text2 = null;
        _ = text2 ?? "no name";
        Console.WriteLine(name);
        Console.WriteLine(text1);
        Console.WriteLine(text2);
    }
}
