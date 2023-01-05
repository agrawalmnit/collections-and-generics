using ConsoleApp49;

namespace ConsoleApp49;

public class Program
{
    public static void Main(string[] args)
    {


        try
        {
            foreach (Worker worker in Workers.TestData)
            {
                Console.WriteLine(worker);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERROR: {e.Message}");
        }
    }
}