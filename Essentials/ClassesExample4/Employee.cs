namespace ClassesExample4;

public class Employee
{
    // Employee constructor
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
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
            // Split the assigned value into 
            // first and last names
            string[] names;
            names = value.Split(new char[] { ' ' });
            if (names.Length == 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                // Throw an exception if the full 
                // name was not assigned
                throw new ArgumentException(string.Format($"Assigned value '{ value }' is invalid", nameof(value)));
            }
        }
    }
}
