namespace ClassesExample3;

internal class Program
{
    static void Main(string[] args)
    {
        Employee employee = new("Inigo", "Montoya")
        {
            Salary = "Too Little"
        };

        Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Salary}");
    }
}
