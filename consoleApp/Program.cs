public class Program
{
    static void Main(string[] args)
    {
        Calculate();
        Console.Read();
    }

    private static void Calculate()
    {
        Console.WriteLine("/// Let's sum two numbers ///");

        Console.Write("Enter the first one: ");
        double num1 = Double.Parse(Console.ReadLine());

        Console.Write("Enter the second one: ");
        double num2 = Double.Parse(Console.ReadLine());

        double result = Add(num1, num2);

        Console.WriteLine($"The result is {result}");
    }

    private static double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}


