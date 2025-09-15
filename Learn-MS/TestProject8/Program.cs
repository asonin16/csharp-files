namespace TestProject8;

class Program
{
    static void Main(string[] args)
    {
        string? readResult;
        // bool validEntry = false;
        Console.WriteLine("Enter an integer value between 5 and 10:");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                int numericValue = 0;

                bool validNumber = int.TryParse(readResult, out numericValue);

                if (validNumber == false)
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");
                    continue;
                }

                if (numericValue < 5 || numericValue > 10)
                {
                    Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
                }
                else
                {
                    Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
                    // validEntry = true;
                    break;
                }
            }
        } while (true);
    }
}
