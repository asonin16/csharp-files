namespace FizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        string text;
        for (int i = 1; i <= 100; i++)
        {
            text = "";
            if (i % 3 == 0)
                text += "Fizz";
            if (i % 5 == 0)
                text += "Buzz";
            Console.WriteLine($"{i}\t{text}");
        }

        for (int i = 1; i < 101; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
                Console.WriteLine($"{i} - FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} - Fizz");
            else if (i % 5 == 0)
                Console.WriteLine($"{i} - Buzz");
            else
                Console.WriteLine($"{i}");
        }
    }
}
