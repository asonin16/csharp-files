namespace ShouldPlayTest;

class Program
{
    static void Main()
    {
        var random = new Random();

        Console.Clear();
        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }

        void PlayGame()
        {
            var play = true;

            while (play)
            {
                var target = random.Next(1, 6);
                var roll = random.Next(1, 7);

                Console.Clear();
                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(roll, target));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }

        string WinOrLose(int roll, int target)
        {
            return (roll > target) ? "You win!" : "You lose!";
        }

        bool ShouldPlay()
        {
            string? response = Console.ReadLine();
            if (response == null)
                return true;
            return response.ToLower().Equals("y");
        }
    }
}
