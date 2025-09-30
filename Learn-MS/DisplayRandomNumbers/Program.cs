namespace DisplayRandomNumbers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Generating random numbers:");
        DisplayRandomNumbers();

        static void DisplayRandomNumbers() 
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++) 
            {
                Console.Write($"{random.Next(1, 100)} ");
            }

            Console.WriteLine();
        }
    }
}
