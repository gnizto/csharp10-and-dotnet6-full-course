using System.Diagnostics;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // Alternative array
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 1, 2, 3 },
                new int[] { 13, 21 }
            };

            Console.WriteLine("The value in the middle of the first entry is {0}", jaggedArray2[0][2]);

            // Get all elements of the jagged array on the console
            Console.WriteLine("---------Challenge---------");
            foreach (int[] array in jaggedArray2) 
            {
                foreach (int item in array)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}


