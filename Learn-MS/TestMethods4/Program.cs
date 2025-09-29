namespace TestMethods4;

class Program
{
    static void Main()
    {
        int a = 3;
        int b = 4;
        int c = 0;

        Multiply(a, b, c);
        Console.WriteLine($"global statement: {a} x {b} = {c}");

        int[] array = { 1, 2, 3, 4, 5 };

        PrintArray(array);
        ClearArray(array);
        PrintArray(array);
    }

    static void Multiply(int a, int b, int c)
    {
        c = a * b;
        Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
    }

    static void PrintArray(int[] array)
    {
        foreach (int a in array)
        {
            Console.Write($"{a} ");
        }
        Console.WriteLine();
    }

    static void ClearArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }
}
