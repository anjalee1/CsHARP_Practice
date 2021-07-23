using System;
using System.Collections.Generic;
using System.Text;

namespace basicCsharp
{
    class SwitchAndLoop
    {

        public static void SwitchCaseandLoops()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Not 10, 20 or 30");

            switch (num)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("Not 10, 20 or 30"); break;
            }



            //for (; ; )
            //{
            //    Console.WriteLine("\"Infinitive For Loop\"");
            //}

            //while(true)
            //{
            //    Console.WriteLine("\"Infinitive While Loop\"");
            //}

            int i = 1;
            do
            {
                int j = 1;

                do
                {

                    Console.WriteLine($"i is {i} and j is {j}");
                    j++;

                }while (j < 4);
                i++;

            }while(i<7);



            
            ineligible:
                Console.WriteLine("You are not eligible to vote!");

                Console.WriteLine("Enter your age:\n");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    goto ineligible;
                }
                else
                {
                    Console.WriteLine("You are eligible to vote!");
                }
            }
        }
    }

