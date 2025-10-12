namespace PromEmployee;

public class Program
{
    public static void PromoteEmployee(Object emp)
    {
        // Cast object to Employee.
        var e = (Employee)emp;
        // Increment employee level.
        e.Emlevel = e.Emlevel + 1;
    }

    static void Main()
    {
        try
        {
            Object o = new Employee();
            var newYears = new DateTime(2001, 1, 1);
            // Promote the new employee.
            PromoteEmployee(o);
            PromoteEmployee(o);
            Console.WriteLine(o.ToString());
            // Promote DateTime; results in InvalidCastException as newYears is not an employee instance.
            // PromoteEmployee(newYears);
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine("Error passing data to PromoteEmployee method. " + e.Message);
        }
    }
}
