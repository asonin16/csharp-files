namespace GenericsAnonymous101;

public class Box<T>
{
    public T? Item { get; set; }

    public void AddItem(T item)
    {
        Item = item;
    }
}
internal class Program
{
    static void Main()
    {
        List<int> numbers = [1, 2, 3];

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        var names = new List<string> { "Hannah", "Mario" };
        string firstName = GetFirstItem(names);
        Console.WriteLine(firstName);
    }

    public static T GetFirstItem<T>(List<T> items)
    {
        return items[0];
    }
}
