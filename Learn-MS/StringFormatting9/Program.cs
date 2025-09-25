namespace StringFormatting9;

class Program
{
    static void Main()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        quantity += input;
        quantity = quantity.Replace("<span>", "=");
        quantity = quantity.Replace("</span>", "=");
        int openingPosition = quantity.IndexOf('=');
        int closingPosition = quantity.LastIndexOf('=');
        openingPosition += 1;
        int length = closingPosition - openingPosition; 
        quantity = quantity.Substring(openingPosition, length);

        output += input;
        output = output.Replace("</div>", "");
        output = output.Replace("<div>", "");
        output = output.Replace("&trade", "&reg");

        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Output: {output}");
    }
}
