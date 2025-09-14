namespace CSExample01;

class Program
{
    static void Main(string[] args)
    {
        // The instance field Name pertains to an instance of a particular Panda,
        // whereas Population pertains to the set of all Pandas:

        var p1 = new Panda("Pan Dee");
        var p2 = new Panda("Pan Dah");
        var p3 = new Panda("Pan Dou");

        Console.WriteLine(p1.Name);      // Pan Dee
        Console.WriteLine(p2.Name);      // Pan Dah
        Console.WriteLine(p3.Name);      // Pan Dou

        Console.WriteLine(Panda.Population);   // 3
    }
    public class Panda
    {
        public string Name;             // Instance field
        public static int Population;   // Static field
        public Panda (string n)         // Constructor
        {
            Name = n;                   // Assign the instance field
            Population++;               // Increment the static Population field
        }
    }
}
