using System;

namespace basicCsharp
{
    class Program
    {
        static void MyMethod(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")

        {

            Console.WriteLine(child3);
            Console.ReadLine();

        }
        static void Main(string[] args)

        {
            //Console.Write("enter your name:");
            //string a = Console.ReadLine();
            //Console.Write($"your name is {a} ?");
            //Console.ReadLine();
            //try
            //{
            Console.Write("Enter First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Seccond Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(num1 / num2);
            // Console.ReadLine();
            Console.ReadKey();
            //}


            //catch(Exception E)
            //{
            //    Console.WriteLine(E.Message);
            //}
            //madLib
            //Console.Write("enter color:");
            //string color = Console.ReadLine();

            //Console.Write("enter pluralNoun:");
            //string pluralNoun = Console.ReadLine();

            //Console.Write("enter celebrity:");
            //string celebrity = Console.ReadLine();


            //Console.WriteLine($"Roses are {color}");
            //Console.WriteLine($"{pluralNoun} are Blue");
            //Console.WriteLine($"I Love {celebrity}");

            //Console.ReadLine();


            //MyMethod("child3");

            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(i);
            //    }




        }


    }
}
