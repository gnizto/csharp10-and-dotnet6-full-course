using System.Diagnostics;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Challenge---------");
            // Challenge: create an array with 5 names
            // Use a foreach to greet them all

            string[] names = new string[5] {"Mom", "Dad", "Diego", "Naomi", "Maria"};

            foreach(string name in names)
            {
                Console.WriteLine("Greetings, {0}!", name);
            }
        }
    }
}


