namespace NewProject503;

class Program
{
    static void Main(string[] args)
    {

    }
}

// Put each interface in separate file

public interface IWork
{
    void DoWork(); // public by default
}

public interface IScaleable
{
    void Scale(double factor);
}
