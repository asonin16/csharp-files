namespace ClassesExample3;

// Employee constructor
public class Employee(string firstName, string lastName)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string? Salary { get; set; } = "Not Enough";
    public string? Title { get; set; }
    public Employee? Manager { get; set; }

    // FullName property
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
        set
        {
            // Split the assigned value into first and last names
            string[] names = value.Split(' ');
            if (names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // Throw an exception if the full name was not assigned
                throw new ArgumentException($"Assigned value '{value}' is invalid", nameof(value));
            }
        }
    }
}
