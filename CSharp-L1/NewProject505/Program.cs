namespace NewProject505;

class Program
{
    const string fileName = "testfile.txt";
    const string dirName = "";
    const string pathName = @"C:\Users\asoni\Documents\csharp-files\CSharp-L1\NewProject505\bin\Debug\net8.0\testfile.txt";

    static void Main(string[] args)
    {
        if (!File.Exists(fileName))
        {
            File.Create(fileName);
        }

        string content = File.ReadAllText(fileName);

        Console.WriteLine(content);

        FileStream fs = File.OpenRead(pathName);
        
    }
}
