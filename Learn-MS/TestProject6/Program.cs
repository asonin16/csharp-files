namespace TestProject6;

class Program
{
    static void Main(string[] args)
    {
        int saleAmount = 1001;
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount}\n");

        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;
        bool found = false;

        foreach (int number in numbers)
        {
            total += number;
            if (number == 42)
                found = true;
        }

        if (found)
            Console.WriteLine("Set contains 42");

        Console.WriteLine($"Total: {total}");
    }
}
