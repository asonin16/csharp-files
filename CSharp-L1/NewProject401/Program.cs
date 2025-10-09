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

        var c3 = new Course("C++ Language", 40);
        var c4 = new Course("Rust language");
        var c5 = new Course();

        // c1.Show();
        // c2.Show();
        c3.Show();
        c4.Show();
        c5.Show();

        Course.PrintCounter();
    }
}
