﻿namespace RenewalRate;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        int daysUntilExpiration = random.Next(12);
        // int discountPercentage = 0;
        string message;

        if (daysUntilExpiration == 0)
        {
            message = "Your subscription has expired.";
        }
        else if (daysUntilExpiration == 1)
        {
            message = "Your subscription expires within a day!\nRenew now and save 20%!";
        }
        else if (daysUntilExpiration <= 5)
        {
            message = $"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!";
        }
        else if (daysUntilExpiration <= 10)
        {
            message = "Your subscription will expire soon. Renew now!";
        }
        else
        {
            message = "";
        }
        Console.WriteLine(message);
    }
}
