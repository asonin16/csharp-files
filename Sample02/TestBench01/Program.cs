namespace TestBench01;

class Program
{
    static void Main(string[] args)
    {
        var company = "Hexlet";
        Console.WriteLine(company.ToUpper()); // => HEXLET
        Console.WriteLine(company.ToLower()); // => hexlet
        Console.WriteLine(company.Length); // => 6

        var name = "Alice";
        var who = name.ToUpper();
        var what = name.ToLower();
        Console.WriteLine($"{who} says: \"{what}\"");

        var one = "Naharis";
        var two = "Mormont";
        var three = "Sand";

        string output = "";
        output += one.Substring(2, 1);
        output += " ";
        output += two.Substring(1, 1);
        output += " ";
        output += three.Substring(3, 1);
        output += " ";
        output += two.Substring(4, 1);
        output += " ";
        output += two.Substring(2, 1);
        Console.WriteLine(output);

        var char1 = one[2];
        var char2 = two[1];
        var char3 = three[3];
        var char4 = two[4];
        var char5 = two[2];
        Console.WriteLine($"{char1} {char2} {char3} {char4} {char5}");
    }
}
