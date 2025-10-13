namespace ClassesExample;

internal class Program
{
    public static void Main(string[] args)
    {
        Employee employee1;

        Employee employee2 = new();
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
