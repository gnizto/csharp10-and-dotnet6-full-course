using System.Diagnostics;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize array grades
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

            // another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 15, 12, 9, 7 };

            // third way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 20, 15, 12, 9, 7, 14 };

            Console.WriteLine("Lenght of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);

            Console.WriteLine("Lenght of gradesOfMathStudentsB: {0}", gradesOfMathStudentsB.Length);
        }


    }
}


