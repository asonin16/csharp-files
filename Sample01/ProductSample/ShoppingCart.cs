namespace ProductSample;

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
