namespace DIctionary101;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> dictionary = new()
        {
            { "Key1", "Val1"},
            { "Key2", "Val2"},
            { "Key3", "Val3"},
            { "Key4", "Val4"}
        };

        string key = "Key3";
        
        if (!dictionary.TryGetValue(key, out string? value))
        {
            Console.WriteLine($"This key '{key}' was not present in the dictionary.");
        }

        // var value = dictionary["Key3"];
        Console.WriteLine($"key: {key}, value: {value}");

        dictionary["Key5"] = "Val5";
        dictionary["Key3"] = "Val#";

        foreach (KeyValuePair<string, string> pair in dictionary)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        foreach ((string k, string v) in dictionary)
        {
            Console.WriteLine($"{k}: {v}");
        }
    }
}
