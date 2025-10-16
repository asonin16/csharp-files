namespace EnumStructRecords103;

public record Dog(string Name, string Breed, int Height, float Weight, int Age);

internal class Program
{
    static void Main()
    {
        var rex = new Dog("Rex", "Schnauzer", 40, 11, 5);
        Console.WriteLine(rex);

        var beauty = rex with { Name = "Beauty", Height = 35 };
        Console.WriteLine(beauty);
        (string name, _, _, _, int age) = beauty;
        Console.WriteLine($"Name = {name}, Age = {age}");
    }
}
