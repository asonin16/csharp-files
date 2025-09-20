namespace AnotherTest3;

class Program
{
    static void Main(string[] args)
    {
        int first = 2;
        string second = "4";
        string result = first + second;
        Console.WriteLine(result);

        int myInt1 = 3;
        Console.WriteLine($"myInt1: {myInt1}");
        decimal myDecimal1 = myInt1;
        Console.WriteLine($"myDecimal1: {myDecimal1}");

        decimal myDecimal2 = 3.14m;
        Console.WriteLine($"myDecimal2: {myDecimal2}");
        int myInt2 = (int)myDecimal2;
        Console.WriteLine($"myInt2: {myInt2}");

        decimal myDecimal3 = 1.23456789m;
        float myFloat3 = (float)myDecimal3;
        Console.WriteLine($"myDecimal3: {myDecimal3}");
        Console.WriteLine($"myFloat3  : {myFloat3}");

        int third = 5;
        int fourth = 7;
        string message = third.ToString() + fourth.ToString();
        Console.WriteLine(message);

        string fifth = "5";
        string sixth = "7";
        int sum56 = int.Parse(fifth) + int.Parse(sixth);
        Console.WriteLine(sum56);

        string value1 = "5";
        string value2 = "7";
        int res12 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
        Console.WriteLine(res12);

        string value3 = "5";
        string value4 = "7";
        if (!int.TryParse(value3, out int res3))
            Console.WriteLine();
        if (!int.TryParse(value4, out int res4))
            Console.WriteLine();
        int res34 = res3 + res4;
        Console.WriteLine(res34);

        int value5 = (int)1.5m; // casting truncates
        Console.WriteLine(value5);
        int value6 = Convert.ToInt32(1.5m); // converting rounds up
        Console.WriteLine(value6);
    }
}
