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
        int counter = 0;
        do
        {
            Console.WriteLine(counter);
            counter++;
        } while (counter < 5);
    }
}


