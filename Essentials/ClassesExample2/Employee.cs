namespace ClassesExample2;

public class Employee
{
    public void Initialize(string newFirstName, string newLastName)
    {
        // Use property inside the Employee
        // class as well
        FirstName = newFirstName;
        LastName = newLastName;
    }

    // LastName property
    public string? LastName
    {
        get { return _LastName; }
        set
        {
            // Validate LastName assignment
            ArgumentException.ThrowIfNullOrEmpty(value = value?.Trim()!);
            _LastName = value;
        }
    }
    private string? _LastName;

    // FirstName property
    public string? FirstName
    {
        get { return _FirstName; }
        set
        {
            // Validate LastName assignment
            ArgumentException.ThrowIfNullOrEmpty(value = value?.Trim()!);
            _FirstName = value;
        }
    }
    private string? _FirstName;
}
