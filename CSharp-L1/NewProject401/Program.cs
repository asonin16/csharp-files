namespace NewProject401;

internal class Program
{
    static void Main(string[] args)
    {
        // var c1 = new Course();
        // c1.Title = "C# Language";
        // c1.Length = 40;

        // var c2 = new Course
        // {
        //     Title = "OOP Patterns",
        //     Length = 24
        // };

        Course.PrintCounter();

        var c3 = new Course("C++ Language", "Short introduction", 40);
        var c4 = new Course("Rust language", "Short introduction");
        var c5 = new Course();
        c5.Title = "Ruby language";
        // c5.Description = "Basic tutorial";
        c5.Length2 = 16;
        var c6 = new Course("Python Language", "Short introduction", 48);

        // c1.Show();
        // c2.Show();
        c3.Show();
        c4.Show();
        c5.Show();
        c6.Show();

        Course.PrintCounter();
    }
}
