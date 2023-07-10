using System.Diagnostics;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declaring a 2D array
            int[,] matrix;

            // Initialing 2D array
            matrix = new int[,]
            {
                {1 ,2 ,3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            Console.WriteLine("Central value is {0}", matrix[1,1]);
            Console.WriteLine("---------Challenge---------");
            Console.WriteLine("The first item on the last row is {0}", matrix[2,0]);
        }
    }
}


