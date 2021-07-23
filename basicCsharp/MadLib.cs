using System;

namespace basicCsharp
{
    class MadLib
    {
        public static void Madlib()
        { 
            firstlineagain: Console.Write("enter color:");
            string color = Console.ReadLine();

            Console.Write("enter pluralnoun:");
            string pluralnoun = Console.ReadLine();

            Console.Write("enter celebrity:");
            string celebrity = Console.ReadLine();


            Console.WriteLine($"roses are {color}");
            Console.WriteLine($"{pluralnoun} are blue");
            Console.WriteLine($"i love {celebrity}");
            Console.WriteLine();
            goto firstlineagain;

            Console.ReadLine();
        }
    }
}
