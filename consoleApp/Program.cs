using System.Runtime.Intrinsics.Arm;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Human gabriel = new Human("Gabriel", "DM", "brow", 29);
            gabriel.IntroduceMyself();

            Human bruce = new Human("Bruce", "Wayne", "blue", 32);
            bruce.IntroduceMyself();
        }


    }
}


