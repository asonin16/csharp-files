namespace Measurement;

public record Measurement(DateTime ReadAt, float Value);

internal class Program
{
    static void Main()
    {
        var random = new Random();
        var measurements = new List<Measurement?> {};

        for (int i = 0; i < 20; i++)
        {
            Measurement? measurement = random.Next(3) != 0
            ? new(DateTime.Now, random.Next(1000) / 1000.0f)
            : null;

            measurements.Add(measurement);
            Console.WriteLine(IsValid(measurement) ? measurement!.ToString() : "-");
            Task.Delay(1000);
        }
    }

    static bool IsValid(Measurement? measurement)
    {
        return measurement != null && measurement.Value >= 0.0f && measurement.Value <= 1.0f;
    }
}
