namespace ClassesExample2;

internal class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new();
        employee1.Initialize("John", "Smith");
        Console.WriteLine($"{employee1.FirstName} {employee1.LastName}");

        Employee employee2 = new();
        employee2.Initialize("John", "");  // throws ArgumentException
        Console.WriteLine($"{employee2.FirstName} {employee2.LastName}");
    }
}
