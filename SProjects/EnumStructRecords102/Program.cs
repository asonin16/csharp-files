namespace EnumStructRecords102;

public enum OrderStatus { Pending, Shipped, Delivered, Cancelled }

internal class Program
{
    static void Main()
    {
        var order = new Order { OrderId = 123, Status = OrderStatus.Pending };
        order.UpdateStatus(OrderStatus.Shipped);
    }
}
