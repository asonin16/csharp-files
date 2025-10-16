namespace EnumStructRecords101;

public static class DaysOfWeekExtensions
{
    public static bool IsWeekend(this DaysOfWeek day)
    {
        return day == DaysOfWeek.Saturday || day == DaysOfWeek.Sunday;
    }
}
