// How to use Destructor
using System;

class Geeks
{
    // Constructor
    public Geeks()
    {
        Console.WriteLine("Object Created.");
    }

    // Destructor
    ~Geeks()
    {
        Console.WriteLine("Object Destroyed.");
    }

    public void DisplayMessage()
    {
        Console.WriteLine("Message Printed.");
    }

    public static void Main(string[] args)
    {
        // Create an instance of Geeks
        Geeks g = new Geeks();

        // Destructor will be called when
        // g goes out of scope
        g.DisplayMessage();
    }
}
