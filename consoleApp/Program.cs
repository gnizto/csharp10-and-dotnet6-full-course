public class Program
{
    static void Main(string[] args)
    {
        WeatherMessage();

        Console.ReadKey();
    }

    private static void WeatherMessage()
    {
        
        bool success;
        int temperature;

        do
        {
            Console.Write("Type the degrees: ");
            string? temperatureInput = Console.ReadLine();

            success = int.TryParse(temperatureInput, out temperature);
            
            if(!success) Console.WriteLine("Please enter a valid temperature!");
        }
        while (!success);

        if (temperature < 10)
        {
            Console.WriteLine("Take the coat!");
        }
        else if (temperature > 10)
        {
            Console.WriteLine("Go use some shorts!");
        }
        else
        {
            Console.WriteLine("Pants and Pull Over should be fine!");
        }
    }
}


