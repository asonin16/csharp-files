namespace ClassesExample;

public class DataStorage
{
     public static void Store(Employee employee)
    {
        // Instantiate a FileStream using FirstNameLastName.dat
        // for the filename. FileMode.Create will force
        // a new file to be created or override an
        // existing file.
        // Note: This code could be improved with a using
        // statement — a construct that we have avoided because
        // it has not yet been introduced.
        FileStream stream = new(employee.FirstName + employee.LastName + ".dat", FileMode.Create);

        // Create a StreamWriter object for writing text
        // into the FileStream
        StreamWriter writer = new(stream);

        // Write all the data associated with the employee
        writer.WriteLine(employee.FirstName);
        writer.WriteLine(employee.LastName);
        writer.WriteLine(employee.Salary);

        // Dispose the StreamWriter and its stream
        writer.Dispose();  // Automatically closes the stream
    }

    public static Employee Load(string firstName, string lastName)
    {
        Employee employee = new();

        // Instantiate a FileStream using FirstNameLastName.dat
        // for the filename. FileMode.Open will open
        // an existing file or else report an error
        FileStream stream = new(firstName + lastName + ".dat", FileMode.Open);

        // Create a StreamReader for reading text from the file
        StreamReader reader = new(stream);

        // Read each line from the file and place it into
        // the associated property.
        employee.FirstName = reader.ReadLine()??
            throw new InvalidOperationException("FirstName cannot be null");
        employee.LastName = reader.ReadLine()??
            throw new InvalidOperationException("LastName cannot be null");
        employee.Salary = reader.ReadLine();

        // Dispose the StreamReader and its Stream
        reader.Dispose();  // Automatically closes the stream

        return employee;
    }
}
