namespace TestMethods5;

class Program
{
    static void Main(string[] args)
    {
        string status1 = "Healthy";

        Console.WriteLine($"Start: {status1}");
        SetHealth1(status1, false);
        Console.WriteLine($"End: {status1}");

        string status2 = "Healthy";

        Console.WriteLine($"Start: {status2}");
        SetHealth2(ref status2, false);
        Console.WriteLine($"End: {status2}");

    }

    static void SetHealth1(string status, bool isHealthy)
    {
        status = (isHealthy ? "Healthy" : "Unhealthy");
        Console.WriteLine($"Middle: {status}");
    }

    static void SetHealth2(ref string status, bool isHealthy) 
    {
        status = (isHealthy ? "Healthy" : "Unhealthy");
        Console.WriteLine($"Middle: {status}");
    }
}
