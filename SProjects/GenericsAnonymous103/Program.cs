using System.Numerics;

namespace GenericsAnonymous103;

internal class Program
{
    static void Main()
    {
        IEnumerable<string> strings = new List<string>();
        IEnumerable<object> objects = strings; // Covariance: string is a more specific type than object

        Action<object> handleObject = obj => Console.WriteLine(obj);
        Action<string> handleString = handleObject; // Contravariance: object is a more general type than string

        int resultInteger = Add(5, 10); // Works with integers
        Console.WriteLine(resultInteger);
        
        double resultDouble = Add(5.5, 10.2); // Works with doubles
        Console.WriteLine(resultDouble);
    }

    static T Add<T>(T left, T right) where T : INumber<T>
    {
        return left + right;
    }
}
