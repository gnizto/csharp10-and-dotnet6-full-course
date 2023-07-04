using System.Runtime.Intrinsics.Arm;

public class Program
{
    static void Main(string[] args)
    {
        ForLoops();

        Console.ReadKey();
    }

    private static void ForLoops()
    {
        for(int counter = 0; counter < 10; counter++)
        {
            if(counter == 3)
            {
                Console.WriteLine("Skip number 3!");
                continue; // go to the next item
                //break;    // stops the loop
            }
            Console.WriteLine(counter);
        }
    }
}


