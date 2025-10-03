namespace Exceptions107;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            OperatingProcedure1();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Exiting application.");
        }

        static void OperatingProcedure1()
        {
            var userEnteredValues = new string[][]
            {
                ["1", "two", "3"],
                ["0", "1", "2"]
            };

            foreach(string[] userEntries in userEnteredValues)
            {
                try
                {
                    BusinessProcess1(userEntries);
                }
                catch (Exception ex)
                {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if (ex.StackTrace.Contains("BusinessProcess1"))
                    {
                        if (ex is FormatException)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Corrective action taken in OperatingProcedure1");
                        }
                        else if (ex is DivideByZeroException)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                            // re-throw the original exception
                            throw;
                        }
                        else
                        {
                            // create a new exception object that wraps the original exception
                            throw new ApplicationException("An error occurred - ", ex);
                        }
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }

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

                    checked
                    {
                        int calculatedValue = 4 / valueEntered;
                    }
                }
                catch (FormatException)
                {
                    var invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                    throw invalidFormatException;
                }
                catch (DivideByZeroException)
                {
                    var unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
                    throw unexpectedDivideByZeroException;

                }
            }
        }
    }
}
