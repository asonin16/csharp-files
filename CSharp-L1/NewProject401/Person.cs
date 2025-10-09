namespace NewProject401;

public class Person(string Name, int Age)  // primary constructor
{
    public string Name { get; set; } = Name;
    public int Age { get; set; } = Age;
}

public record class Person2 (string Name, int Age)  // primary constructor
{
    public string Name { get; set; } = Name;
    public int Age { get; set; } = Age;
}
