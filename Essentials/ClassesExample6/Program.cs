namespace ClassesExample6;

internal class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new("Inigo", "Montoya");
        Employee employee2 = new(42);
        employee2.FirstName = "John Doe";

        Console.WriteLine($"{employee1.Id} - {employee1.FullName}: {employee1.Salary}");
        Console.WriteLine($"{employee2.Id} - {employee2.FullName}: {employee2.Salary}");
    }
}
