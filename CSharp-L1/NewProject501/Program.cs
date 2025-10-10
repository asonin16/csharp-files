using System.Reflection;

namespace NewProject501;

class Program
{
    static void Main(string[] args)
    {
        var obj = new object();
        var type = obj.GetType();

        // MethodInfo mi = type.GetMethod("Name");
        // PropertyInfo pi = type.GetProperty("Show");

        // Without reflection
        Program foo = new();
        foo.PrintHello();

        // With reflection
        // Object foo1 = Activator.CreateInstance("complete.classpath.and.Program");
        // MethodInfo method = foo1.GetType().GetMethod("PrintHello");
        // method.Invoke(foo1, null);

    }

    public void PrintHello()
    {
        Console.WriteLine("Hello, world!");
    }
}
