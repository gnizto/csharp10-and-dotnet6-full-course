using System.Diagnostics;

namespace consoleApp
{
    public class Program
    {
        static int[,] matrix = new int[,]
            {
                {1 ,2 ,3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };
        static void Main(string[] args)
        {
            // Initialing 2D array
            

            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nThis is our 2D array printed using nested for loop");
            // outer loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // inner loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
        }
    }
}


