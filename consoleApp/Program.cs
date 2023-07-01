public class Program
{
    static void Main(string[] args)
    {
        WeatherMessage();

        Console.ReadKey();
    }

    private static void WeatherMessage()
    {
        Console.Write("Type the degrees: ");
        string temperatureInput = Console.ReadLine();
        int temperature = int.Parse(temperatureInput);

        if (temperature < 10)
        {
            Console.WriteLine("The the coat");
        }

        if (temperature == 10)
        {
            Console.WriteLine("It's 10 degrees Celsius");
        }

        if (temperature > 10)
        {
            Console.WriteLine("Cozy & warm!");
        }
    }
}


