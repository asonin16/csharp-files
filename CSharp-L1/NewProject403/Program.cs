namespace NewProject403;

class Program
{
    static void Main(string[] args)
    {
        // Anonymous class / object
        var book = new { Title = "Title", Author = "Author", Price = 212.95M };
        Console.WriteLine(book);
        Console.WriteLine(book.Title);
        Console.WriteLine(book.Author);
        Console.WriteLine(book.Price);
    }
}
