using System.Collections;

namespace TestBench07;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetSentenceTone("Hello")); // "normal"
        Console.WriteLine(GetSentenceTone("WOW"));  // "scream"

        Console.WriteLine(NormalizeUrl("google.com")); // "https://google.com"
        Console.WriteLine(NormalizeUrl("https://ai.fi")); // "https://ai.fi"

        Console.WriteLine(GetTypeOfSentence("Who?")); // "Sentence is question"
        Console.WriteLine(GetTypeOfSentence("No"));   // "Sentence is general"
        Console.WriteLine(GetTypeOfSentence("No!"));  // "Sentence is exclamation"

        Console.WriteLine(WhoIsThisHouseToStarks("Karstark")); // "friend"
        Console.WriteLine(WhoIsThisHouseToStarks("Frey"));     // "enemy"
        Console.WriteLine(WhoIsThisHouseToStarks("Joar"));     // "neutral"
        Console.WriteLine(WhoIsThisHouseToStarks("Ivanov"));   // "neutral"

        var str = "new text";
        Console.WriteLine(char.IsUpper(str[0]));

        Console.WriteLine(GetNumberExplanation(8));   // null

        // Объяснения есть только для указанных ниже чисел
        Console.WriteLine(GetNumberExplanation(666)); // "devil number"
        Console.WriteLine(GetNumberExplanation(42));  // "answer for everything"
        Console.WriteLine(GetNumberExplanation(7));   // "prime number"
    }

    public static string GetSentenceTone(string sentence)
    {
        if (sentence.Equals(sentence.ToUpper()))
        {
            return "scream";
        }
        return "normal";
    }

    public static string NormalizeUrl(string input)
    {
        if (input.StartsWith("https://"))
        {
            return input;
        }
        return $"https://{input}";
    }

    public static string GetTypeOfSentence(string sentence)
    {
        string sentenceType;

        if (sentence.EndsWith('?'))
        {
            sentenceType = "question";
        }
        else if (sentence.EndsWith('!'))
        {
            sentenceType = "exclamation";
        }
        else
        {
            sentenceType = "general";
        }
        return $"Sentence is {sentenceType}";
    }

    public static string WhoIsThisHouseToStarks(string family)
    {
        if (family.Equals("Karstark") || family.Equals("Tally"))
        {
            return "friend";
        }
        else if (family.Equals("Lannister") || family.Equals("Frey"))
        {
            return "enemy";
        }
        return "neutral";
    }

    public static string? GetNumberExplanation(int number)
    {
        switch (number)
        {
            case 7:
                return "prime number";
            case 42:
                return "answer for everything";
            case 666:
                return "devil number";
            default:
                return null;
        }

    }
}
