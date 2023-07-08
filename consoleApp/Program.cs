using System.Diagnostics;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            for(int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element at position {0} = {1}", j, nums[j]);
            }

            // Using foreach
            int position = 0;
            foreach(int num in nums)
            {
                Console.WriteLine("Element at position {0} = {1}", position, num);
                position++;
            }
        }
    }
}


