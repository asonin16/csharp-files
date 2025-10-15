using System.Globalization;

namespace DateTimeExamples2;

class Program
{
    static void Main()
    {
        DateTime today = DateTime.Now; // Get the current date and time
        DayOfWeek day = today.DayOfWeek; // Retrieve the current day of the week
        Console.WriteLine("Today is: " + day);

        DateTime nextSunday = today.AddDays(7 - (int)day); // Calculate the next Sunday
        Console.WriteLine("Next Sunday is on: " + nextSunday.ToShortDateString());

        bool isWeekend = day == DayOfWeek.Saturday || day == DayOfWeek.Sunday; // Check if today is a weekend
        Console.WriteLine("Is today a weekend? " + isWeekend);

        // Retrieve the current culture and UI culture
        CultureInfo currentCulture = CultureInfo.CurrentCulture;
        CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
        Console.WriteLine("\nCurrent Culture: " + currentCulture.Name);
        Console.WriteLine("Current UI Culture: " + currentUICulture.Name);

        // Set a new culture and UI culture
        CultureInfo newCulture = new CultureInfo("en-US");
        CultureInfo.CurrentCulture = newCulture;
        CultureInfo.CurrentUICulture = newCulture;
        Console.WriteLine("New Culture: " + CultureInfo.CurrentCulture.Name);
        Console.WriteLine("New UI Culture: " + CultureInfo.CurrentUICulture.Name);

        Console.WriteLine("Today in New Culture: " + today.ToShortDateString());

        CultureInfo oldCulture = new CultureInfo("ru-RU");
        CultureInfo.CurrentCulture = oldCulture;
        CultureInfo.CurrentUICulture = oldCulture;

        // Create a calendar instance
        Calendar calendar = CultureInfo.InvariantCulture.Calendar;

        // Get the number of days in February 2023
        int daysInMonth = calendar.GetDaysInMonth(2024, 2);
        Console.WriteLine("\nDays in February 2024: " + daysInMonth);

        // Determine the week of the year for December 31, 2024
        DateTime date = new DateTime(2024, 12, 31);
        CalendarWeekRule rule = CalendarWeekRule.FirstDay;
        DayOfWeek firstDayOfWeek = DayOfWeek.Sunday;
        int weekOfYear = calendar.GetWeekOfYear(date, rule, firstDayOfWeek);
        Console.WriteLine("Week of the year for December 31, 2024: " + weekOfYear);

        DateTime dateX = new DateTime(2025, 1, 5);
        CalendarWeekRule ruleX = CalendarWeekRule.FirstFourDayWeek;
        DayOfWeek firstDayOfWeekX = DayOfWeek.Sunday;
        int weekOfYearX = calendar.GetWeekOfYear(dateX, ruleX, firstDayOfWeekX);
        Console.WriteLine("Week of the year: " + weekOfYearX);
    }
}
