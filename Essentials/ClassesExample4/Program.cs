namespace ClassesExample4;

internal class Program
{
    static void Main(string[] args)
    {
        Employee employee;
        employee = new("Inigo", "Montoya")
        {
            Salary = "Too Little"
        };
        Console.WriteLine("{0} {1}: {2}", employee.FirstName, employee.LastName, employee.Salary);

        List<Employee> employees = new()
        {
            new("John", "Donovan"),
            new("Miles", "Davis"),
            new("Thomas", "Black")
        };

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.Salary}");
        }
    }
}
