namespace NewProject502;

class Program
{
    static void Test(string s1, string s2)
    {
        try
        {
            int n1 = int.Parse(s1);
            int n2 = int.Parse(s2);

            if (n1 < 0 || n2 > 100)
                throw new ArgumentOutOfRangeException("out of range");

            int n = n1 / n2;

            Console.WriteLine("n = " + n);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException)
        {
            throw;  //Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("finally!!!");
        }

        Console.WriteLine("to be continued...");
        }

    static void Main(string[] args)
    {
        try
        {
            Test("12", "4");
            Test("abc", "4");
            Test("25", "4");
            // Test("12", "0");
            Test("12", "101");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
