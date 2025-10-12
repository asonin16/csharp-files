using System.Collections;

namespace HashTable101;

class Program
{
    static void Main(string[] args)
    {
        Hashtable ht1 = new()
        {
            { "Key1", "Val1"},
            { "Key2", "Val2"}
        };
        ht1.Add("Key3", "Val3");
        ht1["Key4"] = "Val4";

        // var value = (string?)ht1["Key1"];

        foreach (DictionaryEntry entry in ht1)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
