namespace Collections102;

internal class Program
{
    static void Main()
    {
        // Example: Managing a list of students

        var students = new List<Student>
        {
            new Student { Name = "Haneul", Age = 20 },
            new Student { Name = "Magda", Age = 22 }
        };

        students.Add(new Student { Name = "Dale", Age = 23 });
        students.RemoveAt(0); // Remove Haneul

        foreach (Student student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
        }

        // Expected output:
        // Name: Magda, Age: 22
        // Name: Dale, Age: 23

    }
}
