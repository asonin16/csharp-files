namespace DateTimeExamples;

class Program
{
    static void Main()
    {
        TimeOnly meetingTime = new TimeOnly(14, 30); // 2:30 PM
        Console.WriteLine($"Meeting Time: {meetingTime}");
        // Example console output: Meeting Time: 14:30

        DateOnly meetingDate = new DateOnly(2025, 10, 20);
        Console.WriteLine($"Meeting Date: {meetingDate}");
        // Example console output: Meeting Date: 20.10.2025

        TimeSpan duration = new TimeSpan(2, 0, 0); // 2 hours
        Console.WriteLine($"Event Duration: {duration}");
        // Example console output: Event Duration: 02:00:00

        DayOfWeek today = DateTime.Now.DayOfWeek;
        Console.WriteLine($"Today is: {today}");
        // Example console output: Today is: [DayOfWeek]

        DateTimeOffset now = DateTimeOffset.Now; // Get the current date and time with offset
        Console.WriteLine($"\nCurrent date and time with offset: {now}");

        DateTimeOffset utcNow = DateTimeOffset.UtcNow; // Get the current UTC date and time with offset
        Console.WriteLine($"Current UTC date and time with offset: {utcNow}");

        DateTimeOffset futureDate = now.AddDays(10); // Add 10 days to the current date and time
        Console.WriteLine($"Date 10 days from now: {futureDate}");

        DateTimeOffset pastDate = now.AddHours(-5); // Subtract 5 hours from the current date and time
        Console.WriteLine($"Date 5 hours ago: {pastDate}");

        TimeSpan difference = futureDate - now; // Calculate the time difference between two dates
        Console.WriteLine($"Difference between now and future date: {difference}");

        DateTime utcNowX = DateTime.UtcNow; // Get current UTC time
        Console.WriteLine($"\nUTC Now: {utcNowX}");

        DateTime estNow = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcNowX, "Eastern Standard Time"); // Convert UTC to EST
        Console.WriteLine($"EST Now: {estNow}");

        TimeZoneInfo localZone = TimeZoneInfo.Local; // Get local time zone
        Console.WriteLine($"Local Time Zone: {localZone.DisplayName}");

        DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcNowX, localZone); // Convert UTC to local time
        Console.WriteLine($"Local Time: {localTime}");

        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"); // Find PST time zone
        DateTime pstTime = TimeZoneInfo.ConvertTime(utcNowX, pstZone); // Convert UTC to PST
        Console.WriteLine($"PST Time: {pstTime}");

        TimeSpan durationX = new TimeSpan(2, 14, 18); // 2 hours, 14 minutes, 18 seconds
        Console.WriteLine($"\nDuration: {durationX}");

        TimeSpan fromDays = TimeSpan.FromDays(1.5); // Create TimeSpan from 1.5 days
        Console.WriteLine($"From Days: {fromDays}");

        TimeSpan fromHours = TimeSpan.FromHours(5.75); // Create TimeSpan from 5.75 hours
        Console.WriteLine($"From Hours: {fromHours}");

        TimeSpan differenceX = TimeSpan.FromHours(10) - TimeSpan.FromMinutes(30); // Subtract intervals
        Console.WriteLine($"Difference: {differenceX}");

        TimeSpan multiplied = TimeSpan.FromMinutes(15) * 2; // Multiply interval
        Console.WriteLine($"Multiplied: {multiplied}");

    }
}
