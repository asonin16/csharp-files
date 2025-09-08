namespace TestBench04;

class Program
{
    static void Main(string[] args)
    {
        var year = GetCurrentYear();
        Console.WriteLine(year);
        Console.WriteLine(year.GetType());

        var number = new double();
        Console.WriteLine(number.GetType());

        var letter = new char();
        Console.WriteLine(letter.GetType());

        var text = new string("");
        Console.WriteLine(text.GetType());
    }

    static int GetCurrentYear()
    {
        // var today = DateTime.Now;
        // var result = today.ToString("yyyy-mm-dd").Substring(0, 4);
        // return Convert.ToInt32(result);

        var currentDate = DateTime.Now.ToString("yyyy-MM-dd");
        var currentYearAsString = currentDate.Substring(0, 4);
        var currentYear = Convert.ToInt32(currentYearAsString);
        return currentYear;
    }
}
