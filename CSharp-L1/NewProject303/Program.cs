namespace NewProject303;

class Program
{
    static void MaxMin(int[] arr, out int max, out int min)
    {
        max = arr[0];
        min = arr[0];
        foreach (var k in arr)
        {
            if (k > max) max = k;
            if (k < min) min = k;
        }
    }
    static (int max, int min) MaxMin(int[] arr) // #TUPLE#
    {
        int max = arr[0];
        int min = arr[0];
        foreach (var k in arr)
        {
            if (k > max) max = k;
            if (k < min) min = k;
        }
        return (max, min);
    }
    static void Main(string[] args)
    {
        int[] array = [23, 5, 12, 78, 12, 2, 99, 34];

        MaxMin(array, out int max, out int min);
        Console.WriteLine($"Maximum = {max}");
        Console.WriteLine($"Minimum = {min}");

        var tuple = MaxMin(array);
        Console.WriteLine($"Maximum = {tuple.max}");
        Console.WriteLine($"Minimum = {tuple.min}");
    }
}
