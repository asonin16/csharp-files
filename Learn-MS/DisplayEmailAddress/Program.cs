namespace DisplayEmailAddress;

class Program
{
    static void Main(string[] args)
    {
        string[,] corporate =
        {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };

        string[,] external =
        {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };

        string externalDomain = "hayworth.com";

        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            // display internal email addresses
            string shortName = "";
            shortName += corporate[i, 0].ToLower().Remove(2);
            shortName += corporate[i, 1].ToLower();
            DisplayEmailAddress(shortName);
        }

        for (int i = 0; i < external.GetLength(0); i++)
        {
            // display external email addresses
            string shortName = "";
            shortName += external[i, 0].ToLower().Remove(2);
            shortName += external[i, 1].ToLower();
            DisplayEmailAddress(shortName, externalDomain);
        }

        void DisplayEmailAddress(string name, string domain = "contoso.com")
        {
            Console.WriteLine($"{name}@{domain}");
        }
    }
}
