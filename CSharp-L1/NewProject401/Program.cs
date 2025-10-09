namespace NewProject401;

class Program
{
    static void Main(string[] args)
    {
        var c1 = new Course();
        c1.Title = "C# Language";
        c1.Length = 40;

        var c2 = new Course
        {
            Title = "OOP Patterns",
            Length = 24
        };

        c1.Show();
        c2.Show();
    }
}
