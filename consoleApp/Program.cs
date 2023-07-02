public class Program
{
    static void Main(string[] args)
    {
        SystemMessage();

        Console.ReadKey();
    }

    private static void SystemMessage()
    {
        bool isAdmin = false;
        bool isRegistered = true;
        string userName = "";
        Console.Write("Please enter your username: ");
        userName = Console.ReadLine();

        if (isRegistered && userName != "" && userName.Equals("admin"))
        {
            Console.WriteLine("Hi there, registered user!");

            Console.WriteLine("Hi there, " + userName);

            Console.WriteLine("Hi there, Admin");
        }

        if(isAdmin || isRegistered)
        {
            Console.WriteLine("You are logged in");
        }
    }
}


