using System.Runtime.Intrinsics.Arm;

public class Program
{
    static void Main(string[] args)
    {
        Loops();

        Console.ReadKey();
    }

    private static void Loops()
    {
        string? name = "";
        int counter = 0;

        while (name?.Length == 0)
        {
            Console.Write("Press enter to increase or enter something to stop counting: ");
            name = Console.ReadLine();
            if(name?.Length == 0) counter++;
            Console.WriteLine("Counter -> {0}", counter);
        }

        Console.WriteLine("Total of input: {0}", counter);
    }
}


