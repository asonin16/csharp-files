namespace TestBench05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Truncate("hexlet", 2)); // "he..."

        // Через переменную
        var text = "it works!";
        // Обрезаем текст, оставляя 4 символа
        var result = Truncate(text, 4);
        Console.WriteLine(result); // => "it w..."

        // можно вызывать так
        Console.WriteLine(Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим", 17));
        // "Три закона робото..."

        // и так
        Console.WriteLine(Truncate("Три закона робототехники придумали кожаные мешки, но мы их перехитрим"));
        // "Три закона..."
    }

    static string Truncate(string text, int length = 10)
    {
        return $"{text.Substring(0, length)}...";
    }
}
