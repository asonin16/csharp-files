using System.Security.Cryptography.X509Certificates;

namespace NewProject304;

class Program
{
    static (double X1, double X2, bool HasRoots, bool IsSingleRoot) SquareRoot(int a, int b, int c)
    {
        bool HasRoots = false;
        bool IsSingleRoot = false;
        double X1 = 0.0;
        double X2 = 0.0;

        int d = b * b - 4 * a * c;

        if (d < 0)
            return (X1, X2, HasRoots, IsSingleRoot);

        if (d == 0)
        {
            IsSingleRoot = true;
            X1 = X2 = (double)-b / (2 * a);
            return (X1, X2, HasRoots, IsSingleRoot);
        }

        HasRoots = true;
        X1 = (double)(-b + Math.Sqrt(d)) / (2 * a);
        X2 = (double)(-b - Math.Sqrt(d)) / (2 * a);
        return (X1, X2, HasRoots, IsSingleRoot);
    }
    static void Main(string[] args)
    {
        var (X1, X2, HasRoots, IsSingleRoot) = SquareRoot(2, 4, -2);

        if (!HasRoots)
        {
            Console.WriteLine("No roots");
            return;
        }

        Console.WriteLine($"X1 = {X1}, X2 = {X2}");
    }
}
