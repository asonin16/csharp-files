namespace DiscountSample;

public static class DiscountCalculator
{
    public static decimal CalculateDiscount(decimal price, decimal discountPercentage)
    {
        return price - (price * discountPercentage / 100);
    }
}
