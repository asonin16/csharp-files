namespace BookSample;

public class Book
{
    // Private field for the book's title
    private string? _title;

    // Property to encapsulate the title field with validation
    public string? Title
    {
        get => _title;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Title cannot be empty or null.");
            _title = value;
        }
    }

    // Read-only property for the author, set in the constructor
    public string Author { get; }

    // Constructor to initialize both title and author

    public Book(string title, string author)
    {
        Title = title;
        Author = string.IsNullOrWhiteSpace(author)
                 ? throw new ArgumentException("Author cannot be empty or null.")
                 : author;
    }

    // Method to display book information
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}
