namespace NewProject401;

public class Course
{
    // public string? Title;
    // private string title;

    // public string Title
    // {
    //     get { return title; }
    //     set { title = value; }
    // }

    public string Title { get; set; } = "New course";

    public string Description { get; }  // Read-only property

    private int length2;

    public const int MIN_LENGTH = 8;
    public const int MAX_LENGTH = 48;

    // public int GetLength()
    // {
    //     return Length;
    // }

    // public void SetLength(int Length)
    // {
    //     if (Length < MIN_LENGTH || Length > MAX_LENGTH)
    //         throw new ArgumentException("Lenght is outside of range");
    //     this.Length = Length;
    // }

    // Property:
    public int Length2
    {
        get { return length2; }
        set
        {
            if (value < MIN_LENGTH || value > MAX_LENGTH)
                throw new ArgumentException("Length is outside of range");
            length2 = value;
        }
    }

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

    public Course() : this("New course", "", 8)
    {
        Console.WriteLine("#Course() stop#");
    }

    public Course(string Title, string Description, int Length2 = 12)
    {
        this.Title = Title;
        this.Description = Description;
        this.Length2 = Length2;
        Counter++;
    }

    public void Show()
    {
        Console.WriteLine($"{Title} : {Description} : {Length2}");
    }

}
