namespace DiscountSample;

class Program
{
    static void Main(string[] args)
    {
        var sp1 = new Smartphone("S24", 40000M, "Samsung", 12);
        var lt1 = new Laptop("ExpertBook", 60000M, "ASUS", 12);

        Console.WriteLine($"sp1 with discount = {sp1.ApplyDiscount(10M)};");
        Console.WriteLine($"lt1 with discount = {lt1.ApplyDiscount(10M)};");
    }
}
