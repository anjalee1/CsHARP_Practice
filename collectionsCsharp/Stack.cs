using System;
using System.Collections.Generic;
using System.Text;

namespace collectionsCsharp
{
    class Stack
    {

        public static void STack()
        {
            var St = new Stack<int>();
            //St.Pop();
            St.Push(1);
            St.Push(2);
            St.Push(3);
            St.Push(4);
            foreach(var item in St)
            {
                Console.Write(item +",");
            }
            Console.WriteLine();

            //create stack from array
            int[] ar = new int[] {5,6,7,0 };
            var St1 = new Stack<int>(ar);
            if (St1.Count > 0)
            {
                Console.WriteLine(St1.Pop());
                 St1.Peek();
            }
            foreach (var item in St1)
            {
                Console.Write(item + ",");
            }
            
           // var St2 = new Stack<int>(){8,9,10,11 };


            Console.ReadKey();
        }
    }
}
