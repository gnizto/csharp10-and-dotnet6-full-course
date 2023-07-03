using System.Runtime.Intrinsics.Arm;

public class Program
{
    static void Main(string[] args)
    {
        Loops();

        Console.ReadKey();
    }

    private static void Loops()
    {
        int lengthOfText = 0;
        string wholeText = "";
        do
        {
            Console.Write("Please enter the name of a friend: ");
            string nameOfAFriend = Console.ReadLine();
            int currentLength = nameOfAFriend.Length;
            lengthOfText += currentLength;
            wholeText += nameOfAFriend;
        } while (lengthOfText < 20);
        Console.WriteLine("Thanks! That was enough! -> {0}", wholeText);
    }
}


