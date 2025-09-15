namespace TestProject9;

class Program
{
    static void Main(string[] args)
    {
        string? readResult;
        string[] roles = ["Administrator", "Manager", "User"];

        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                string tempResult = readResult.Trim().ToLower();

                if (tempResult == roles[0].ToLower())
                    tempResult = roles[0];
                else if (tempResult == roles[1].ToLower())
                    tempResult = roles[1];
                else if (tempResult == roles[2].ToLower())
                    tempResult = roles[2];
                else
                {
                    Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
                    continue;
                }
                Console.WriteLine($"Your input value ({readResult}) has been accepted.");
                break;
            }

        } while (true);
    }
}
