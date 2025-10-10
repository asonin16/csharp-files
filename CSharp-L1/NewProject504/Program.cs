namespace NewProject504;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GC.MaxGeneration);
        Console.WriteLine(GC.CollectionCount(0));
        Console.WriteLine(GC.GetTotalMemory(false));
        Console.WriteLine(GC.GetTotalAllocatedBytes());

        // GC.Collect(GC.MaxGeneration);
        // GC.WaitForFullGCComplete();

        // GC.AddMemoryPressure(10000);
        // // can be used for unsafe code
        // GC.RemoveMemoryPressure(10000);

        // var obj = new Object();
        // GC.SuppressFinalize(obj);
        // GC.ReRegisterForFinalize(obj);

        // ### OPTION 1 ###
        DBConnection dbc = new DBConnection();
        try
        {
            dbc.Execute();
        }
        finally
        {
            dbc.Dispose();
        }

        // ### OPTION 2 ###
        using (DBConnection conn = new DBConnection())
        {
            conn.Execute();
            //conn.Dispose();
        }

        // ### OPTION 3 ###
        using DBConnection dcon = new DBConnection();
        
    }

    public class DBConnection : IDisposable
    {
        public DBConnection() => Console.WriteLine("Open connection");
        public void Execute() => Console.WriteLine("Execute command");
        public void Dispose() => Console.WriteLine("Close connection");
        
        // public virtual void Dispose(bool disposing)
        // {
        //     if (disposing)
        //     {
        //         // TODO
        //         Console.WriteLine("Close connection");
        //     }
        // }

    }
}
