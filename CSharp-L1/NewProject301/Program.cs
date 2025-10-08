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
    }
}
