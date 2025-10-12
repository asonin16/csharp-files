using System.Collections;

namespace HashTable101;

class Program
{
    static void Main(string[] args)
    {
        /* Hashtable methods:
            Add, Remove, Clear, Clone,
            Contains, ContainsKey, ContainsValue,
            Equals, GetHashCode, GetType...
            ...and properties:
            Count, Keys, Values
        */

        Hashtable hashtable = new()
        {
            { "Key1", "Val1"},
            { "Key2", "Val2"}
        };
        hashtable.Add("Key3", "Val3");
        hashtable["Key4"] = "Val4";
        hashtable["Key5"] = "Val5";

        // var value = (string?)hashtable["Key1"];

        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        Console.WriteLine($"Count: {hashtable.Count}");

        var keys = hashtable.Keys;
        var values = hashtable.Values;

        foreach (string key in keys)
        {
            Console.WriteLine(key);
        }

        foreach (string value in values)
        {
            Console.WriteLine(value);
        }
    }
}
