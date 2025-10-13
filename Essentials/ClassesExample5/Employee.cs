namespace ClassesExample5;

public class Employee
{
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
        Salary = null;
    }

    // ...

    public int Id { get; }
    public string Name { get; }
    
    public string? Salary
    {
        get { return _Salary; }
        init { _Salary = value; }
    }
    private string? _Salary;
}
