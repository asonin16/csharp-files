namespace ClassesExample5;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new(42, "Inigo Montoya")
        {
            Salary = "Sufficient"
        };

#if COMPILEERROR // EXCLUDE

        // ERROR:  Property or indexer 'Employee.Salary' 
        // cannot be assigned after initialization completes.
        employee.Salary = "Enough";

#endif // COMPILEERROR // EXCLUDE

        Console.WriteLine($"{employee.Id} - {employee.Name}: {employee.Salary}");
    }
}
