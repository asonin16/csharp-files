using System;
using System.Collections.Generic;

public class ShoppingCart
{
    private List<Product> _products = new List<Product>();

    public void AddProduct(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.Price;
        }
        return total;
    }

    public void DisplayTotal()
    {
        Console.WriteLine($"Total Price: {CalculateTotalPrice()}");
    }
}

public class Product
{
    required public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        var cart = new ShoppingCart();

        cart.AddProduct(new Product { Name = "Laptop", Price = 999.99 });
        cart.AddProduct(new Product { Name = "Mouse", Price = 25.50 });
        cart.AddProduct(new Product { Name = "Backpack", Price = 34.50 });

        cart.DisplayTotal();
    }
}
