namespace TestBench03;

class Program
{
    static void Main(string[] args)
    {
        var war = "War of the Kings";
        var missingWord = "Five ";

        // string[] words = war.Split(" ");
        // var newPhrase = "";
        // for (int i = 0; i < words.Length - 1; i++)
        // {
        //     newPhrase += words[i] + " ";
        // }
        // newPhrase += missingWord;
        // newPhrase += words[words.Length - 1];
        // Console.WriteLine(newPhrase);

        var kingWordIndex = war.IndexOf("Kings");
        Console.WriteLine(war.Insert(kingWordIndex, missingWord));

        var emoji = "-(";
        var happyEmoji = ":" + emoji.Replace('(', ')');
        Console.WriteLine(happyEmoji);

        Console.WriteLine(Greeting());
    }

    static string Greeting()
    {
        return "Winter is coming!";
    }
}
