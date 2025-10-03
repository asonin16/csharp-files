namespace Exceptions106;

class Program
{
    static void Main(string[] args)
    {
        // var invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
        // throw invalidArgumentException;

        // throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");

        var userEnteredValues = new string[][]
        {
            ["1", "two", "3"],
            ["0", "1", "2"]
        };

        foreach (string[] userEntries in userEnteredValues)
        {
            try
            {
                BusinessProcess1(userEntries);
            }
            catch (Exception ex)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
                {
                    Console.WriteLine(ex.Message);
                }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }

        static void BusinessProcess1(string[] userEntries)
        {
            int valueEntered;

            foreach (string userValue in userEntries)
            {
                try
                {
                    valueEntered = int.Parse(userValue);

                    // completes required calculations based on userValue
                    // ...
                }
                catch (FormatException)
                {
                    var invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                    throw invalidFormatException;
                }
            }
        }
    }
}
