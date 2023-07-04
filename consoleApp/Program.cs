using System.Runtime.Intrinsics.Arm;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Human gabriel = new Human();
            gabriel.firstName = "Gabriel";
            gabriel.lastName = "DM";
            gabriel.IntroduceMyself();

            Human bruce = new Human();
            bruce.firstName = "Bruce";
            bruce.lastName = "Wayne";
            bruce.IntroduceMyself();
        }


    }
}


