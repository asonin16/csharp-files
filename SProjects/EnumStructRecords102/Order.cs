namespace EnumStructRecords102;

public class Order
{
    public int OrderId { get; set; }
    public OrderStatus Status { get; set; }

    public void UpdateStatus(OrderStatus newStatus)
    {
        Status = newStatus;
        Console.WriteLine($"Order {OrderId} status updated to {Status}");
    }
}
