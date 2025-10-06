namespace NewProject102;
/// <summary>
/// Main program
/// </summary>
internal class Program
{
    /// <summary>
    /// Entry point
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, Brave New World!");

        int a = 10;
        int b = a;
        a++;
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"{a.GetType()}");

        int[] arr1 = { 10, 11, 12 };
        int[] arr2 = arr1;
        arr1[0]++;
        Console.WriteLine($"arr1[0] = {arr1[0]}");
        Console.WriteLine($"arr2[0] = {arr2[0]}");
        Console.WriteLine($"{arr1.GetType()}");

        string s1 = "one";
        string s2 = "two";
        s2 += "!!!";
        string s3 = "one";
        bool b1 = (s1 == s3);
        bool b2 = s1.Equals(s3);
        Console.WriteLine($"s1 = {s1}");
        Console.WriteLine($"s2 = {s2}");
        Console.WriteLine($"{s1.GetType()}");
        Console.WriteLine($"b1 = {b1}");
        Console.WriteLine($"b2 = {b2}");
        Console.WriteLine($"{b1.GetType()}");
    }
}
