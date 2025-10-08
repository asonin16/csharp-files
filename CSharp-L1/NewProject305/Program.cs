namespace NewProject305;

class Program
{
    static void Main(string[] args)
    {
        // #ARRAY#
        double[] data1 = new double[15];
        int size = 5;
        double[] data2 = new double[size];
        int[] data3 = { 100, 200, 300 };

        int count1 = data1.Length;
        int count2 = data2.Length;
        int count3 = data3.Length;
        Console.WriteLine(count1);
        Console.WriteLine(count2);
        Console.WriteLine(count3);

        for (int i = 0; i < data3.Length; i++)
        {
            Console.WriteLine(data3[i]);
        }

        int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine(matrix.Length);
        Console.WriteLine(matrix.GetLength(0));
        Console.WriteLine(matrix.GetLength(1));
        Console.WriteLine(matrix.Rank);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, 3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int[][] jagged = new int[][] { [1, 2, 3], [4, 5, 6, 7, 8] };

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write("{0, 3}", jagged[i][j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // #RANGE#
        int[] d1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Range r = 2..6;
        int[] d2 = d1[r];
        foreach (int d in d1)
            Console.Write(d);
        Console.WriteLine();
        foreach (int d in d2)
            Console.Write(d);
        Console.WriteLine();

        // #ARRAY IN STACK#
        Span<int> numbers = stackalloc int[] { 23, 34, 45, 56, 67 };
        foreach (int number in numbers)
            Console.WriteLine(number);
        Console.WriteLine();
    }
}
