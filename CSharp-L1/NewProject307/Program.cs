namespace NewProject307;

class Program
{
    static void Main(string[] args)
    {
        int length = args.Length;

        if (length == 0)
        {
            Console.WriteLine("Error: no input provided.");
            return;
        }

        int[] nums = new int[length];

        for (int i = 0; i < length; i++)
        {
            if (!int.TryParse(args[i], out nums[i]))
            {
                Console.WriteLine("Error: not correct inputs.");
                return;
            }
        }

        int max = nums[0];
        int min = nums[0];
        int sum = 0;

        foreach (var num in nums)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
            sum += num;
        }

        double avg = (double)sum / length;

        Console.WriteLine($"Maximum = {max}");
        Console.WriteLine($"Minimum = {min}");
        Console.WriteLine($"Amount = {sum}");
        Console.WriteLine($"Average = {avg}");

        Array.Sort(nums);
        Console.Write($"Sorted: ");
        foreach (var num in nums)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();

        Array.Reverse(nums);
        Console.Write($"Reversed: ");
        foreach (var num in nums)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}
