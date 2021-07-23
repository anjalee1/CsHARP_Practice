using System;
using System.Collections.Generic;
using System.Text;

namespace basicCsharp
{
    class Start
    {
        public static void GettingStarted()
        {

            Console.Write("enter your name:");
            string a = Console.ReadLine();
            Console.Write($"your name is {a} ?");
            Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);

            }

        }
    }
}
