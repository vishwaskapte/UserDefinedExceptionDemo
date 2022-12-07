public class MyNewException : Exception
{
    public MyNewException(string ex)
    {
        Console.WriteLine(ex);
    }
}

class Program
{
    public static void Main()
    {
        try
        {
            throw new MyNewException("User defined exception!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Catching Exception: " + e.Message);
        }
        Console.WriteLine("Next statement to be executed");
        Console.Read();
    }
}