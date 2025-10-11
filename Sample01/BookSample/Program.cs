namespace BookSample;

class Program
{
    static void Main(string[] args)
    {
        var myBook = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        myBook.DisplayInfo(); // Output: Title: The Great Gatsby, Author: F. Scott Fitzgerald
    }
}
