namespace NewProject401;

public class Course
{
    public string? Title;
    public int Length;
    static int Counter = 0;
    public static void PrintCounter()
    {
        // "this" variable is not available here (static) directly
        Console.WriteLine($"Course counter: {Counter}");
    }
    static Course()
    {
        // it is called when the class is invoked for a first time
    }
    public Course() : this("New course", 8)
    {
        Console.WriteLine("#Course() stop#");
    }
    public Course(string Title, int Length = 12)
    {
        this.Title = Title;
        this.Length = Length;
        Counter++;
    }
    public void Show()
    {
        Console.WriteLine($"{Title} : {Length}");
    }

}
