using System;

namespace basicCsharp
{
    class FunctioCall
    {

        public static void Callbyvalue(int val )
            {
            val *= val;
            Console.WriteLine("value inside function" + val);
           }

        public static void Callbyreference(ref int val1)
        {
            val1 *= val1;
            Console.WriteLine("value inside function" + val1);
        }


        public static void OutParameter(out int val2)
        {
            val2 = 30;
            val2 *= val2;
            Console.WriteLine("value inside function" + val2);
        }

        public static void DefaultParameter(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")

        {

            Console.WriteLine(child3);
            Console.ReadLine();

        }

}
}
