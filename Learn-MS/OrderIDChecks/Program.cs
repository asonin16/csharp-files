﻿namespace OrderIDChecks;

class Program
{
    static void Main(string[] args)
    {
        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        string[] ordersIDs = orderStream.Split(',');
        Array.Sort(ordersIDs);

        foreach (var orderID in ordersIDs)
        {
            string message = orderID;
            if (orderID.Length != 4)
            {
                message += "\t- Error";
            }
            Console.WriteLine(message);
        }
    }
}
