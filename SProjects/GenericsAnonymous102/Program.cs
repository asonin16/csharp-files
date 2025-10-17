namespace GenericsAnonymous102;

public class Product : IComparable<Product>
{
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public int CompareTo(Product? other)
    {
        return Price.CompareTo(other?.Price);
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}";
    }
}

public class ProductComparer : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        return x.Price.CompareTo(y.Price);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}

internal class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200 },
            new Product { Name = "Tablet", Price = 600 },
            new Product { Name = "Monitor", Price = 400 },
            new Product { Name = "Smartphone", Price = 800 }
        };

        products.Sort(new ProductComparer());

        foreach (var product in products)
        {
            Console.WriteLine(product.ToString());
        }
    }
}
