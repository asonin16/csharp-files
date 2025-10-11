namespace DiscountSample;

public class Laptop
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Brand { get; set; }
    public int WarrantyPeriod { get; set; }

    public Laptop(string name, decimal price, string brand, int warrantyPeriod)
    {
        Name = name;
        Price = price;
        Brand = brand;
        WarrantyPeriod = warrantyPeriod;
    }

    public decimal ApplyDiscount(decimal discountPercentage)
    {
        return DiscountCalculator.CalculateDiscount(Price, discountPercentage);
    }
}
