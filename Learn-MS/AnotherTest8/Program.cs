namespace AnotherTest8;

class Program
{
    static void Main(string[] args)
    {
        string value = "abc123";
        char[] valueArray = value.ToCharArray();
        Array.Reverse(valueArray);
        string result = new string(valueArray);
        Console.WriteLine(result);
    }
}
