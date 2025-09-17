namespace PalindromeLength;

public class Program
{
    public static void Main()
    {
        string? palindrome;

        Console.Write("Enter a palindrome: ");
        palindrome = Console.ReadLine();

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        Console.WriteLine($"The palindrome \"{palindrome}\" is {palindrome.Length} characters.");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}
