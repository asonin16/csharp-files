namespace NewProject401;

public class RemoteCourse : Course
{
    public string Url { get; set; } = null!;

    public const int MIN_LENGTH2 = 8;
    public const int MAX_LENGTH2 = 40;

    private int length2;
    public override int Length2
    {
        get { return length2; }
        set
        {
            if (value < MIN_LENGTH2 || value > MAX_LENGTH2)
                throw new ArgumentException("Length is outside of range");
            length2 = value;
        }
    }

    public RemoteCourse(string Title, string Description, int Lenght2, string Url)
        : base(Title, Description, Lenght2)
    {
        this.Url = Url;
    }

    public void Connect()
    {
        Console.WriteLine($"Open connection to {Url}");
    }

    public override void Show()
    {
        Console.WriteLine($"{Title} : {Description} : {Length2} - {Url}");
    }

}
