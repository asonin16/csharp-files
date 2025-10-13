namespace ClassesExample;

internal class Program
{
    public static void Main(string[] args)
    {
        Employee employee1 = new();
        Employee employee2 = new();

        employee1.FirstName = "Inigo";
        Console.WriteLine(employee1.FirstName);

        employee2.Title = "Computer Nerd";
        employee1.Manager = employee2;

        Console.WriteLine(employee1.Manager.Title);

        employee2.SetName("Inigo", "Montoya");
        employee2.Save();

        // Modify employee2 after saving
        IncreaseSalary(employee2);

        // Load employee1 from the saved version of employee2
        employee1 = DataStorage.Load("Inigo", "Montoya");

        Console.WriteLine($"{employee1.GetName()}: {employee1.Salary}");
    }
    
    public static void IncreaseSalary(Employee employee)
    {
        employee.Salary = "Enough to survive on";
    }
}
