namespace StringFormatting5;

class Program
{
    static void Main(string[] args)
    {
        string message1 = "Find what is (inside the parentheses)";

        int openingPosition1 = message1.IndexOf('(');
        int closingPosition1 = message1.IndexOf(')');

        openingPosition1 += 1;

        // Console.WriteLine(openingPosition);
        // Console.WriteLine(closingPosition);

        int length1 = closingPosition1 - openingPosition1;
        Console.WriteLine(message1.Substring(openingPosition1, length1));

        string message = "What is the value <span>between the tags</span>?";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingPosition2 = message.IndexOf(openSpan);
        int closingPosition2 = message.IndexOf(closeSpan);

        openingPosition2 += openSpan.Length;
        int length2 = closingPosition2 - openingPosition2;
        Console.WriteLine(message.Substring(openingPosition2, length2));
    }
}
