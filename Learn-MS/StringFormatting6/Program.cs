namespace StringFormatting6;

class Program
{
    static void Main(string[] args)
    {
        string message1 = "hello there!";

        int first_h = message1.IndexOf('h');
        int last_h = message1.LastIndexOf('h');

        Console.WriteLine($"For the message: '{message1}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

        string message2 = "(What if) I am (only interested) in the last (set of parentheses)?";

        int openingPosition2 = message2.LastIndexOf('(');
        openingPosition2 += 1;
        int closingPosition2 = message2.LastIndexOf(')');
        int length2 = closingPosition2 - openingPosition2;
        Console.WriteLine(message2.Substring(openingPosition2, length2));

        string message3 = "(What if) there are (more than) one (set of parentheses)?";
        while (true)
        {
            int openingPosition3 = message3.IndexOf('(');
            if (openingPosition3 == -1) break;

            openingPosition3 += 1;
            int closingPosition3 = message3.IndexOf(')');
            int length3 = closingPosition3 - openingPosition3;
            Console.WriteLine(message3.Substring(openingPosition3, length3));

            // Note the overload of the Substring to return only the remaining 
            // unprocessed message:
            message3 = message3.Substring(closingPosition3 + 1);
        }
    }
}
