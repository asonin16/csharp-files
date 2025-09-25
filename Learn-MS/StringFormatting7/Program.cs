namespace StringFormatting7;

class Program
{
    static void Main()
    {
        // PART 1
        string message1 = "Hello, world!";
        char[] charsToFind1 = { 'a', 'e', 'i' };

        int index1 = message1.IndexOfAny(charsToFind1);
        Console.WriteLine($"Found '{message1[index1]}' in '{message1}' at index: {index1}.");

        // PART 2
        string message2 = "Help (find) the {opening symbols}";
        Console.WriteLine($"Searching THIS Message: {message2}");
        char[] openSymbols2 = { '[', '{', '(' };
        int startPosition2 = 5;

        int openingPosition2 = message2.IndexOfAny(openSymbols2);
        Console.WriteLine($"Found WITHOUT using startPosition: {message2.Substring(openingPosition2)}");

        openingPosition2 = message2.IndexOfAny(openSymbols2, startPosition2);
        Console.WriteLine($"Found WITH using startPosition {startPosition2}:  {message2.Substring(openingPosition2)}");

        // PART 3
        string message3 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        // The IndexOfAny() helper method requires a char array of characters. 
        // You want to look for:

        char[] openSymbols3 = { '[', '{', '(' };

        // You'll use a slightly different technique for iterating through 
        // the characters in the string. This time, use the closing 
        // position of the previous iteration as the starting index for the 
        //next open symbol. So, you need to initialize the closingPosition 
        // variable to zero:

        int closingPosition3 = 0;

        while (true)
        {
            int openingPosition3 = message3.IndexOfAny(openSymbols3, closingPosition3);

            if (openingPosition3 == -1) break;

            string currentSymbol3 = message3.Substring(openingPosition3, 1);

            // Now  find the matching closing symbol
            char matchingSymbol3 = ' ';

            switch (currentSymbol3)
            {
                case "[":
                    matchingSymbol3 = ']';
                    break;
                case "{":
                    matchingSymbol3 = '}';
                    break;
                case "(":
                    matchingSymbol3 = ')';
                    break;
            }

            // To find the closingPosition, use an overload of the IndexOf method to specify 
            // that the search for the matchingSymbol should start at the openingPosition in the string. 

            openingPosition3 += 1;
            closingPosition3 = message3.IndexOf(matchingSymbol3, openingPosition3);

            // Finally, use the techniques you've already learned to display the sub-string:

            int length3 = closingPosition3 - openingPosition3;
            Console.WriteLine(message3.Substring(openingPosition3, length3));
        }
    }
}
