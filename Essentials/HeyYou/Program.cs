namespace HeyYou;

public class Program
{
    public static void Main()
    {
        string? firstName;
        string? lastName;

        Console.WriteLine("Hey you!");

        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your full name is {firstName} {lastName}.");
    }
}
