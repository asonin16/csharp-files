namespace TestBench08;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MultiplyNumbersFromRange(1, 5)); // 1 * 2 * 3 * 4 * 5 = 120
        Console.WriteLine(MultiplyNumbersFromRange(2, 3)); // 2 * 3 = 6
        Console.WriteLine(MultiplyNumbersFromRange(6, 6)); // 6

        Console.WriteLine(JoinNumbersFromRange(1, 1)); // "1"
        Console.WriteLine(JoinNumbersFromRange(2, 3)); // "23"
        Console.WriteLine(JoinNumbersFromRange(5, 10)); // "5678910"

        Console.WriteLine(CountChars("HexlEt", 'e')); // 2
        Console.WriteLine(CountChars("HexlEt", 'E')); // 2

        var str = "If I look back I am lost";
        Console.WriteLine(FilterString(str, 'I')); // "f  look back  am lost"
        Console.WriteLine(FilterString(str, 'o')); // "If I lk back I am lst"

        var text1 = "I never look back";
        Console.WriteLine(MakeItFunny(text1, 3)); // "I NevEr LooK bAck"
        var text2 = "hello";
        Console.WriteLine(MakeItFunny(text2, 2)); // "hElLo"

        Console.WriteLine(Encrypt("move")); // "omev"
        Console.WriteLine(Encrypt("attack")); // "taatkc"
        Console.WriteLine(Encrypt("go!")); // "og!"
    }

    public static int MultiplyNumbersFromRange(int start, int finish)
    {
        // BEGIN (write your solution here)
        int result = 1;
        for (int i = start; i <= finish; i++)
        {
            result *= i;
        }
        return result;
        // END
    }

    public static string JoinNumbersFromRange(int j, int k)
    {
        var result = "";
        for (int i = j; i <= k; i++)
        {
            result += i.ToString();
        }
        return result;
    }

    public static int CountChars(string str, char ch)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.ToLower(str[i]) == char.ToLower(ch))
                count++;
        }
        return count;
    }

    public static string FilterString(string str, char ch)
    {
        var result = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != ch)
                result += str[i];
        }
        return result;
    }

    public static string MakeItFunny(string text, int count)
    {
        var result = "";
        for (int i = 0; i < text.Length; i++)
        {
            if ((i + 1) % count != 0)
                result += text[i];
            else
                result += char.ToUpper(text[i]);
        }
        return result;
    }

    public static string Encrypt(string str)
    {
        // BEGIN (write your solution here)
        var result = "";
        int length;
        
        if (str.Length % 2 == 0)
            length = str.Length;
        else
            length = str.Length - 1;

        for (int i = 0; i < length - 1; i += 2)
        {
            result += str[i + 1];
            result += str[i];
        }

        if (str.Length % 2 != 0)
            result += str[str.Length - 1];

        return result;
        // END
    }
}
