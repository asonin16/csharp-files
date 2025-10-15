using Newtonsoft.Json;
using System.Globalization;

namespace FilesDirectories;

internal class Program
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        var currentDirectory = Directory.GetCurrentDirectory();
        var storesDirectory = Path.Combine(currentDirectory, "stores");

        var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");

        if (!Directory.Exists(salesTotalDir))
        {
            Directory.CreateDirectory(salesTotalDir);
        }

        var salesFiles = FindFiles(storesDirectory);

        var salesTotal = CalculateSalesTotal(salesFiles);

        File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");

        // foreach (var file in salesFiles)
        // {
        //     Console.WriteLine(file);
        // }

        // Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores", "201", "newDir"));

        // bool doesDirectoryExist = Directory.Exists(filePath);

        // File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");

        /*
        Console.WriteLine(Directory.GetCurrentDirectory());
        Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
        Console.WriteLine(Path.Combine("stores", "201")); // outputs: stores/201
        Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json
        // returns:
        // stores\201 on Windows
        // stores/201 on macOS

        string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";
        var info = new FileInfo(fileName);
        string NL = Environment.NewLine;
        Console.WriteLine($"Full Name: {info.FullName}{NL}Directory: {info.Directory}{NL}Extension: {info.Extension}{NL}Create Date: {info.CreationTime}"); // And many more
        */

        // var salesFiles = FindFiles(@"C:\Users\asoni\Documents\csharp-learn\mslearn-dotnet-files\stores");
        // var salesFiles = FindFiles("stores");

    }

    static IEnumerable<string> FindFiles(string folderName)
    {
        List<string> salesFiles = new List<string>();

        var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

        foreach (var file in foundFiles)
        {
            // // The file name will contain the full path, so only check the end of it
            // if (file.EndsWith("sales.json"))
            // {
            //     salesFiles.Add(file);
            // }

            var extension = Path.GetExtension(file);
            if (extension == ".json")
            {
                salesFiles.Add(file);
            }

        }

        return salesFiles;
    }

    static decimal CalculateSalesTotal(IEnumerable<string> salesFiles)
    {
        decimal salesTotal = 0;

        // Loop over each file path in salesFiles
        foreach (var file in salesFiles)
        {
            // Read the contents of the file
            string salesJson = File.ReadAllText(file);

            // Parse the contents as JSON
            SalesTotal? data = JsonConvert.DeserializeObject<SalesTotal?>(salesJson);

            // Add the amount found in the Total field to the salesTotal variable
            salesTotal += data?.Total ?? 0;
        }

        return salesTotal;
    }

    // record SalesData (double Total);

}
