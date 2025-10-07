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
        Console.WriteLine("name: " + name);
        Console.WriteLine("text1: " + text1);
        Console.WriteLine("text2: " + text2);

        // switch expression
        int num = 2;
        string res = num switch
        {
            0 or 1 => "one",
            2 => "two",
            3 => "three",
            _ => "many"
        };
        Console.WriteLine(res);

        int abc = 2;
        string str = abc switch
        {
            1 => "one",
            >= 2 and <= 7 => "many",
            _ => "a lot"
        };
        Console.WriteLine(str);

        object obj = "sample string";
        obj = 5;
        int k = (int)obj;
        Console.WriteLine(k);

        switch (obj)
        {
            case int i when i is > 0 and <= 100:
                Console.WriteLine("one"); break;
            case string:
                Console.WriteLine("string"); break;
        }

        Console.Write("Enter your name: ");
        string? input = Console.ReadLine(); // ?? "";
        Console.WriteLine($"Hello, {input}!");
    }
}
