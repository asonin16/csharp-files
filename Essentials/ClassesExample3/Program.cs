namespace ClassesExample3;

internal class Program
{
    static void Main(string[] args)
    {
        Employee employee = new("Inigo", "Montoya");
        employee.Salary = "Too Little";
        // {
        //     Salary = "Too Little"
        // };

        Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Salary}");
    }
}
