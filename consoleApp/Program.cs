public class Program
{
    static void Main(string[] args)
    {
        StateOfMatter();

        Console.ReadKey();
    }

    private static void StateOfMatter()
    {
        int temperature = -5;
        string stateOfMatter;

        // Challenge 
        stateOfMatter = temperature < 0 ? "Solid" : "Liquid";

        Console.WriteLine("State of Matter is {0}", stateOfMatter);
    }
}


