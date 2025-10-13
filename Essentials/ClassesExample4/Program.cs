namespace ClassesExample4;

internal class Program
{
    static void Main(string[] args)
    {
        Employee emp = new("Inigo", "Montoya")
        {
            Title = "Computer Nerd",
            Salary = "Too Little"
        };
        Console.WriteLine("{0} {1}, {3}: {2}", emp.FirstName, emp.LastName, emp.Salary, emp.Title);

        List<Employee> employees = new()
        {
            new("John", "Donovan"),
            new("Miles", "Davis"),
            new("Thomas", "Black"),
            new("Barry", "White")
        };

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Salary}");
        }
    }
}
