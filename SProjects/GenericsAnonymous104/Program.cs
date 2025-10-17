namespace GenericsAnonymous104;

internal class Program
{
    static void Main()
    {
        var v = new { Amount = 108, Message = "Hello" };
        Console.WriteLine($"{v.Amount} - {v.Message}");

        var p = new { Name = "Laptop", Price = 1200 };
        Console.WriteLine($"Product: {p.Name}, Price: {p.Price}");

        var products = new[] {
            new { Name = "Laptop", Price = 1200 },
            new { Name = "Tablet", Price = 600 },
            new { Name = "Display", Price = 400 },
            new { Name = "Printer", Price = 700 },
            new { Name = "Smartphone", Price = 1500 }
        };

        var filteredProducts = from pr in products
                            where pr.Price < 1000
                            select new { pr.Name, pr.Price };

        foreach (var product in filteredProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }

        var customer = new { Name = "Mario Rogers", Age = 30 };
        Console.WriteLine($"Customer: {customer.Name}, Age: {customer.Age}");

    }
}
