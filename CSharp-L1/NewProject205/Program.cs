namespace NewProject205;

class Program
{
    static void Main()
    {
        bool doExit = false;

        do
        {
            Console.Write("Введите количество ворон: ");
            string? input = Console.ReadLine();

            if (input?.ToLower() == "exit")
            {
                doExit = true;
                continue;
            }

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Ошибка: введено не числовое значение.");
                continue;
            }

            if (number < 0)
            {
                Console.WriteLine("Ошибка: введено отрицательное число.");
                continue;
            }

            int result = number;

            if (number > 20)
            {
                result %= 10;
            }
            else if (number > 4)
            {
                result = 0;
            }

            string text = result switch
            {
                0 => "ворон",
                1 => "ворона",
                2 or 3 or 4 => "вороны",
                _ => "ворон",
            };
            Console.WriteLine($"На ветке {number} {text}");
        }
        while (!doExit);
    }
}
