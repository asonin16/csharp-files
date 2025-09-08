// Demonstration of Destructor
using System;

class Complex
{
    private int real, img;

    // Constructor
    public Complex()
    {
        real = 0;
        img = 0;
    }

    // Method to set values
    public void SetValue(int r, int i)
    {
        real = r;
        img = i;
    }

    // Method to display values
    public void DisplayValue()
    {
        Console.WriteLine($"Real = {real}, Imaginary = {img}");
    }

    // Destructor
    ~Complex()
    {
        Console.WriteLine("Object Destroyed");
    }
}

class Geeks
{
    static void Main(string[] args)
    {
        // Create instance
        Complex c = new Complex();

        c.SetValue(2, 3);
        c.DisplayValue();

        // Destructor will be called automatically
        // when 'c' goes out of scope.
    }
}
