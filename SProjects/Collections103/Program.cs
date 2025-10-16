namespace Collections103;

internal class Program
{
    static void Main()
    {
        HashSet<string> names = new HashSet<string>();
        names.Add("Haneul");
        names.Add("Magda");
        names.Add("Joseph");
        names.Add("Magda");
        names.Remove("Jesus");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Output (order may vary):
        // Haneul
        // Magda

        if (names.Contains("Haneul"))
        {
            Console.WriteLine("Haneul is in the collection.");
        }

        // Output:
        // Haneul is in the collection.

        var emailAddresses = new HashSet<string>();
        emailAddresses.Add("user1@example.com");
        emailAddresses.Add("user2@example.com");
        emailAddresses.Add("user1@example.com"); // Duplicate, won't be added

        foreach (string email in emailAddresses)
        {
            Console.WriteLine(email);
        }

        // Output:
        // user1@example.com
        // user2@example.com

    }
}
