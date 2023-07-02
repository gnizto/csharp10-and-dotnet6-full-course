public class Program
{
    static void Main(string[] args)
    {
        AgeCheck();

        Console.ReadKey();
    }

    private static void AgeCheck()
    {
        int age = 25;

        switch(age)
        {
            case 15:
                Console.WriteLine("Too young to party in the club!");
                break;
            case 25:
                Console.WriteLine("Good to go!");
                break;
            default:
                Console.WriteLine("How old are you then?");
                break;
        }

        // If...Else version
        if(age == 15)
        {
            Console.WriteLine("Too young to party in the club!");
        } else if(age == 25)
        {
            Console.WriteLine("Good to go!");
        } else
        {
            Console.WriteLine("How old are you then?");
        }
    }
}


