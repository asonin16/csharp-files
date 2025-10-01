namespace CodeDebugging;

class Program
{
    static void Main(string[] args)
    {
        var students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

        int studentCount = students.Length;

        Console.WriteLine("The final name is: " + students[studentCount - 1]);
    }
}
