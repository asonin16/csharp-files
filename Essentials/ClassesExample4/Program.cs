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
    }
}
