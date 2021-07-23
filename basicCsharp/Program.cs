using System;

namespace basicCsharp
{
    class Program
    {
        //static void MyMethod(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")

        //{

        //    Console.WriteLine(child3);
        //    Console.ReadLine();

        //}
        static void Main()

        {
            //try
            //{
            //    Console.WriteLine("Enter a Number");

            //    int val = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine(E.Message);
            //    }
            //Boolean t = Convert.ToBoolean(val);
            //Console.WriteLine($"Converted value is : {t}");

            //Nullable obj = new Nullable();
            ////Console.WriteLine(Nullable.s2);
            //Console.WriteLine(obj.s4);
            //Nullable.Nullabletype();
            //SwitchAndLoop.SwitchCaseandLoops();
            //Nullable.NullableHelper();
            //Array.MultiArray();
            Array.JaggedArray();
            Array.Params( 4, 5, 6, 7, 8, 9 );
            Array.Params( 7, 8, 9);
            
            int data = 20;
            Console.WriteLine("value before calling function" + data);
            FunctioCall.Callbyvalue(data);
            Console.WriteLine("value after calling function" + data);


            Console.WriteLine("value before calling function" + data);
            FunctioCall.Callbyreference(ref data);
            Console.WriteLine("value after calling function" + data);

            FunctioCall.OutParameter(out data);

            //Console.Write("enter your name:");
            //string a = Console.ReadLine();
            //Console.Write($"your name is {a} ?");
            //Console.ReadLine();
            //try
            //{
            //Console.Write("Enter First Number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Seccond Number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write(num1 / num2);
            //// Console.ReadLine();
            //Console.ReadKey();
            //}


            //catch(Exception E)
            //{
            //    Console.WriteLine(E.Message);
            //}
            //madLib
            //firstlineagain: Console.Write("enter color:");
            //        string color = Console.ReadLine();

            //        Console.Write("enter pluralNoun:");
            //        string pluralNoun = Console.ReadLine();

            //        Console.Write("enter celebrity:");
            //        string celebrity = Console.ReadLine();


            //        Console.WriteLine($"Roses are {color}");
            //        Console.WriteLine($"{pluralNoun} are Blue");
            //        Console.WriteLine($"I Love {celebrity}");
            //        goto firstlineagain;

            //Console.ReadLine();


            //MyMethod("child3");

            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine(i);
            //    }




        }


        }
    }

