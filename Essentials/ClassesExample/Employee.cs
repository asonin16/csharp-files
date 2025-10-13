namespace ClassesExample;

public class Employee
{
    public string? FirstName
    {
        get { return _FirstName; }
        set { _FirstName = value; }
    }
    private string? _FirstName;
    public string? LastName
    {
        get { return _LastName; }
        set { _LastName = value; }
    }
    private string? _LastName;
    public string? Title { get; set; }
    public Employee? Manager { get; set; }
    public string? Salary { get; set; } = "Not Enough";
/*
    private string? Password;
    private bool IsAuthenticated;
*/ 
    public string GetName()
    {
        return $"{ FirstName } { LastName }";
    }

    public void SetName(string newFirstName, string newLastName)
    {
        this.FirstName = newFirstName;
        this.LastName = newLastName;
        Console.WriteLine(
            $"Name changed to '{ this.GetName() }'");
    }

    public void Save()
    {
        DataStorage.Store(this);
    }
/*
    public bool Logon(string password)
    {
        if (Password == password)
        {
            IsAuthenticated = true;
        }
        return IsAuthenticated;
    }

    public bool GetIsAuthenticated()
    {
        return IsAuthenticated;
    }
*/
}
