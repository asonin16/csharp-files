namespace EnumStructRecords101;

public enum Season { Spring, Summer, Autumn, Winter }

public enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

public enum ErrorCode : ushort { None = 0, Unknown = 1, ConnectionLost = 100, OutlierReading = 200 }
    
internal class Program
{
    static void Main()
    {
        DaysOfWeek day = (DaysOfWeek)3;
        Console.WriteLine(day); // Outputs: Wednesday

        bool isValid = Enum.IsDefined(typeof(DaysOfWeek), 3);
        Console.WriteLine(isValid); // Outputs: True

        DaysOfWeek today = DaysOfWeek.Saturday;
        Console.WriteLine(today.IsWeekend()); // Outputs: True
    }
}
