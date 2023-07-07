using System.Diagnostics;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.Write("Enter some note: ");
            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine("Grades at index 0: {0}", grades[0]);
        }


    }
}


