namespace EnumStructRecords105;

public record Person(string FirstName, string LastName);
public record Product(string Name, decimal Price)
{
    public override int GetHashCode() => HashCode.Combine(Name.ToLower(), Price);
}
public record Point(int X, int Y);
public record Animal(string Name);
public record Dog(string Name, string Breed) : Animal(Name);

class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person("Chris", "Kuo");
        var person2 = new Person("Chris", "Kuo");
        Console.WriteLine(person1 == person2); // Output: True

        var point = new Point(3, 4);
        Console.WriteLine(point); // Output: Point { X = 3, Y = 4 }

        var dog = new Dog("Buddy", "Golden Retriever");
        Console.WriteLine(dog); // Output: Dog { Name = Buddy, Breed = Golden Retriever }

        var product1 = new Product("Laptop", 1200m);
        var product2 = new Product("Laptop", 1200m);
        var product3 = new Product("Tablet", 600m);
        Console.WriteLine($"Are product1 and product2 equal? {product1 == product2}");
        Console.WriteLine($"Are product1 and product3 equal? {product1 == product3}");

    }
}
