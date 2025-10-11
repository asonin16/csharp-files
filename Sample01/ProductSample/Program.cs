namespace ProductSample;

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
