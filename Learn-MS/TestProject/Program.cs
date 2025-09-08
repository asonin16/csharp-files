namespace TestProject;

class Program
{
    static void Main(string[] args)
    {
        // var dice = new Random();
        Random dice = new();
        int roll = dice.Next(1, 99);
        Console.WriteLine(roll);

        var result = new Random();
        int outcome = result.Next();
        Console.WriteLine(outcome);
        // Console.Clear();
    }
}
