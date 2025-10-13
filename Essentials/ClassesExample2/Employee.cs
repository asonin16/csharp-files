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

    // Name property
    public string Name
    {
        get
        {
            return $"{ FirstName } { LastName }";
        }
        set
        {

#if !NET7_0_OR_GREATER
            value = value?.Trim() ??
                throw new ArgumentException("Value cannot be null, empty or whitespace");
#else

            ArgumentException.ThrowIfNullOrEmpty(value = value?.Trim()!);

#endif // NET7_0_OR_GREATER

            // Split the assigned value into 
            // first and last names
            string[] names;
            names = value.Split(new char[] { ' ' });
            if(names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // Throw an exception if the full 
                // name was not assigned
                throw new ArgumentException($"Assigned value '{ value }' is invalid",
                    nameof(value));
            }
        }
    }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
    public string Initials()
    {
        return $"{FirstName[0]} {LastName[0]}";
    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

    // Title property
    public string? Title { get; set; }

    // Manager property
    public Employee? Manager { get; set; }

}
