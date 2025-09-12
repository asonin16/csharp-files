namespace RandomTest3;

class Program
{
    static void Main(string[] args)
    {
        Random coin = new Random();

        int flip = coin.Next(1, 11);

        Console.WriteLine("test result: " + (flip > 5 ? "heads" : "tails"));
    }
}
