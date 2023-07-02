public class Program
{
    static void Main(string[] args)
    {
        StateOfMatter();

        Console.ReadKey();
    }

    private static void StateOfMatter()
    {
        int temperature = 5;
        string stateOfMatter;

        // Challenge -> Add the gas state of matter to the options
        stateOfMatter = temperature < 0 ? "Solid" : temperature > 100 ? "Gas" : "Liquid";

        Console.WriteLine("State of Matter is {0}", stateOfMatter);
    }
}


