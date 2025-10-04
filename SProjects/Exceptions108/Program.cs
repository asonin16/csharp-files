﻿namespace Exceptions108;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for the lower and upper bounds
        Console.Write("Enter the lower bound: ");
        string? userInput1 = Console.ReadLine() ?? throw new NullReferenceException();
        int lowerBound = int.Parse(userInput1);

        Console.Write("Enter the upper bound: ");
        string? userInput2 = Console.ReadLine() ?? throw new NullReferenceException();
        int upperBound = int.Parse(userInput2);

        decimal averageValue = 0;
        bool exit = false;

        do
        {
            try
            {
                // Calculate the sum of the even numbers between the bounds
                averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

                // Display the result to the user
                Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

                exit = true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("An error has occurred.");
                Console.WriteLine(ex.Message);
                Console.WriteLine($"The upper bound must be greater than {lowerBound}");
                Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
                string? userResponse = Console.ReadLine() ?? throw new NullReferenceException();
                if (userResponse.ToLower().Contains("exit"))
                {
                    exit = true;
                }
                else
                {
                    exit = false;
                    upperBound = int.Parse(userResponse);
                }
            }

        } while (exit == false);

        // Wait for user input
        Console.ReadLine();

        static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
        {
            if (lowerBound >= upperBound)
            {
                throw new ArgumentOutOfRangeException(nameof(upperBound), "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
            }

            int sum = 0;
            int count = 0;
            decimal average = 0;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            average = (decimal)sum / count;

            return average;
        }
        
    }
}
