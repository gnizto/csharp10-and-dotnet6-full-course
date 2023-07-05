using System.Runtime.Intrinsics.Arm;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Human gabriel = new Human("Gabriel", "DM", "brow", 29);
            gabriel.IntroduceMyself();

            Human bruce = new Human("Bruce", "Wayne", "blue");
            bruce.IntroduceMyself();

            Human human1 = new Human("Bruce", "Wayne");
            human1.IntroduceMyself();

            Human human2 = new Human("Bruce");
            human2.IntroduceMyself();

            Human human3 = new Human();
            human3.IntroduceMyself();
        }


    }
}


