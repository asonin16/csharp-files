namespace TestProject4;

class Program
{
    static void Main(string[] args)
    {
        /*
        The following code reverses the srting and calculates the number of 'o'.
        */
        string str = "The quick brown fox jumps over the lazy dog.";

        char[] charMessage = str.ToCharArray();
        Array.Reverse(charMessage);

        int x = 0;

        foreach (char i in charMessage)
        {
            if (i == 'o')
            {
                x++;
            }
        }
        var new_message = new String(charMessage);

        Console.WriteLine(new_message);
        
        Console.WriteLine($"'o' appears {x} times.");
    }
}
