public class Program
{
    static void Main(string[] args)
    {
        Calculate();
        Console.Read();
    }

    private static void Calculate()
    {
        Console.WriteLine("Please enter a number: ");
        string userInput = Console.ReadLine();

        try
        {
            int num = 0;
            int result = 6 / num;
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Can't divide by zero!");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Something went wrong");
            Console.WriteLine(ex.Message);
        }

        try
        {
            int userInputAsInt = int.Parse(userInput);
        }
        catch (FormatException)
        {
            Console.WriteLine("Form Exception! Please enter a valid number!");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            Console.WriteLine("This is called anyways!");
        }

        
    }
}


