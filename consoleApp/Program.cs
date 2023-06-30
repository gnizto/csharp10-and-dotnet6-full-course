public class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 3;
        int num3;

        // unary operators
        num3 = -num1;
        Console.WriteLine("num3 is {0}", num3);

        bool isSunny = true;
        Console.WriteLine("Is it sunny? {0}", !isSunny);

        // increment operator
        int num = 0;
        num++;
        Console.WriteLine("num is {0}", num);
        Console.WriteLine("num is {0}", num++);
        // pre increment
        Console.WriteLine("num is {0}", ++num);

        // decrement operator
        num--;
        Console.WriteLine("num is {0}", num);
        Console.WriteLine("num is {0}", num--);
        // pre decrement
        Console.WriteLine("num is {0}", --num);


        int result;
        result = num1 + num2;
        Console.WriteLine("Result of num1 + num2 is {0}", result);

        result = num1 - num2;
        Console.WriteLine("Result of num1 - num2 is {0}", result);

        result = num1 / num2;
        Console.WriteLine("Result of num1 / num2 is {0}", result);

        result = num1 * num2;
        Console.WriteLine("Result of num1 * num2 is {0}", result);

        // Module
        result = num1 % num2;
        Console.WriteLine("Result of num1 % num2 is {0}", result);

        // Relational and type operators
        bool isLower;
        isLower = num1 < num2;
        Console.WriteLine("Result of num1 < num2 is {0}", isLower);

        bool isGreater;
        isGreater = num1 > num2;
        Console.WriteLine("Result of num1 > num2 is {0}", isGreater);

        bool isEqual;
        isEqual = num1 == num2;
        Console.WriteLine("Result of num1 == num2 is {0}", isEqual);

        bool isNotEqual;
        isNotEqual = num1 != num2;
        Console.WriteLine("Result of num1 != num2 is {0}", isNotEqual);

        // conditional operators
        bool isLowerAndSunny;
        isLowerAndSunny = isLower && isSunny;
        Console.WriteLine("Result of isLower && isSunny is {0}", isLowerAndSunny);

        bool isLowerOrSunny;
        isLowerOrSunny = isLower || isSunny;
        Console.WriteLine("Result of isLower || isSunny is {0}", isLowerOrSunny);

        Console.ReadKey();
    }
}


