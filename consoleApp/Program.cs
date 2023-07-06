using System.Runtime.Intrinsics.Arm;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);

            box.Width = 10;

            Console.WriteLine("Box lenght is " + box.GetLength());

            box.DisplayInfo();
        }


    }
}


