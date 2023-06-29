public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Add(15, 31));

        int multiplyResult = Multiply(30, 3);
        Console.WriteLine("The multiplication result is: " + multiplyResult);

        double divideResult = Divide(25, 13);
        Console.WriteLine("The division result is: " + divideResult);

        Console.Read();
    }

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public static double Divide(double num1, double num2)
    {
        return num1 / num2;
    }
}


