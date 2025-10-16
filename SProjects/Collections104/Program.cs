namespace Collections104;

internal class Program
{
    static void Main()
    {
        var students = new Dictionary<int, string>
        {
            { 101, "Ji-min Jo" },
            { 102, "Catalina Blaga" }
        };

        students.Add(103, "Milan Golob"); // Add a new key-value pair

        foreach (var kvp in students)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Expected output:
        // Key: 101, Value: Ji-min Jo
        // Key: 102, Value: Catalina Blaga
        // Key: 103, Value: Milan Golob

        var student = students[101];
        Console.WriteLine(student); // Outputs "Ji-min Jo"

        // Expected output:
        // Ji-min Jo

        var phonebook = new Dictionary<string, string>
        {
            { "Ji-min Jo", "312-555-0100" },
            { "Catalina Blaga", "251-555-0101" }
        };

        Console.WriteLine(phonebook["Ji-min Jo"]); // Access Ji-min's phone number

        // Expected output:
        // 312-555-0100

        var productPrices = new Dictionary<int, decimal>
        {
            { 201, 19.99m },
            { 202, 29.99m }
        };

        Console.WriteLine($"Product 201 costs ${productPrices[201]}");

        // Expected output:
        // Product 201 costs $19.99

    }
}
