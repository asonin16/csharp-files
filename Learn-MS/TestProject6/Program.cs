namespace TestProject6;

class Program
{
    static void Main(string[] args)
    {
        int saleAmount = 1001;
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount}");
    }
}
