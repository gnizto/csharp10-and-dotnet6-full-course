﻿using System.Runtime.Intrinsics.Arm;

namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //box.length = 3;
            box.SetLength(3);
            box.height = 4;
            box.width = 5;

            box.DisplayInfo();
        }


    }
}


