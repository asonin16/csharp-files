using Microsoft.VisualBasic;

namespace NewProject401;

internal class Program
{
    static void Main()
    {
        var p1 = new Person("Sergey", 48);
        var p2 = new Person("Sergey", 48);
        Console.WriteLine(p1);
        Console.WriteLine(p2.ToString());
        Console.WriteLine(p1 == p2);
        Console.WriteLine(p1.Equals(p2));

        var p3 = new Person2("Alexey", 55);
        var p4 = new Person2("Alexey", 55);
        Console.WriteLine(p3);
        Console.WriteLine(p4.ToString());
        Console.WriteLine(p3 == p4);
        Console.WriteLine(p3.Equals(p4));

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

        var rc1 = new RemoteCourse("Title", "Description", 40, "www.specialist.ru");
        // {
        //     Title = "Title",
        //     Description = "Description",
        //     Length2 = 40,
        //     Url = "www.specialist.ru"
        // };

        rc1.Show();
        rc1.Connect();

        var c7 = rc1;
        // var rc2 = (RemoteCourse)c4;
        // rc2.Show();
        // rc2.Connect();

        // if (c7 is RemoteCourse)
        // {
        //     var rc2 = (RemoteCourse)c4;
        //     rc2.Show();
        //     rc2.Connect();
        // }

        if (c7 is RemoteCourse rc3)
        {
            rc3.Show();
            rc3.Connect();
        }

        var rc4 = c4 as RemoteCourse;
        rc4?.Show();
        rc4?.Connect();

        Course.PrintCounter();

        // RemoteCourse.PrintCounter();

    }
}
