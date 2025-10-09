using System;

namespace NewProject401;

public class Course
{
    public string? Title;
    public int Length;
    public void Show()
    {
        Console.WriteLine($"{Title} : {Length}");
    }

}
