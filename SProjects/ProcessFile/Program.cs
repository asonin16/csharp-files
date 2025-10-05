namespace ProcessFile;

public class ProcessFile
{
    public static void Main()
    {
        try
        {
            using StreamReader sr = File.OpenText("/resources/testdata12.txt");
            Console.WriteLine($"The 1st line of this file is {sr.ReadLine()}");
            Console.WriteLine($"The 2nd line of this file is {sr.ReadLine()}");
            Console.WriteLine($"The 3rd line of this file is {sr.ReadLine()}");
            sr.Close();
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"The file was not found: '{e}'");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine($"The directory was not found: '{e}'");
        }
        catch (IOException e)
        {
            Console.WriteLine($"The file could not be opened: '{e}'");
        }
    }
}
