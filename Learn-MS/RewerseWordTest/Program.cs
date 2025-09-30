namespace RewerseWordTest;

class Program
{
    static void Main(string[] args)
    {
        string input1 = "snake";

        Console.WriteLine(input1);
        Console.WriteLine(ReverseWord(input1));

        string input2 = "there are snakes at the zoo";

        Console.WriteLine(input2);
        Console.WriteLine(ReverseSentence(input2));

        string ReverseWord(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }

        string ReverseSentence(string input)
        {
            string result = "";
            string[] words = input.Split(" ");
            foreach (string word in words)
            {
                result += ReverseWord(word) + " ";
            }
            return result.Trim();
        }
    }
}
