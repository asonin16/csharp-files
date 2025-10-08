using System.Text;
using System.Text.RegularExpressions;

namespace NewProject306;

class Program
{
    static void Main(string[] args)
    {
        // #STRING#

        string str1 = string.Empty;
        string str2 = "Sample Text";
        var str3 = new string("Sample Text");
        string str4 = str2 + " " + str3;
        var str5 = new string('@', 20);

        Console.WriteLine(str1.Length);
        Console.WriteLine(str2 == str3);
        Console.WriteLine(str4);
        Console.WriteLine(str4[0..6]);
        Console.WriteLine(str4[^3]);
        Console.WriteLine(str5);

        /*
        <stringname> Methods:
        .ToUpper()
        .ToLower()
        .Trim()
        .Contains("ttt")
        .CompareTo()
        .Index.Of("m")
        .Replace('ch1', 'ch2')
        .ToArray()
        */

        /*
        string. class Methods:
        .Compare()
        .Concat()
        .Create()
        .Equals()
        .Format()
        .IsNullOrEmpty()
        .Join
        */

        // #STRING BUILDER#

        var sb = new StringBuilder();

        for (int i = 0; i < 100; i++)
        {
            sb.Append(i).Append(" ");
        }

        string res1 = sb.ToString();
        Console.WriteLine(res1);

        // #STRING FORMAT#

        string res2 = string.Format("Hello {0} - {1}", str2, str5);
        Console.WriteLine(res2);

        /*
        .ToString()
        .Parse()
        .TryParse()
        */

        // #REGEX#

        Regex reg = new Regex(@"\d{3}-[1..9]\d{2}-\d{2}-\d{2}");

        string phone1 = "499-127-23-89";
        string phone2 = "499-027-23-89";
        Console.WriteLine(reg.IsMatch(phone1));
        Console.WriteLine(reg.IsMatch(phone2));
    }
}
