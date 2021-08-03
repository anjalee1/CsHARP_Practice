using System;
using System.Collections.Generic;
using System.Text;

namespace basicCsharp
{
    class BoxingAndUnboxing
    {
        public static void BoxUnbox()
        {
            int i = 46;
             // boxing
            object o = i;
            int j= (int)o;

            Console.WriteLine(o);
            Console.WriteLine(j);

            Console.WriteLine((1.ToString().GetType()));
            Console.WriteLine(i.Equals(o));
            Console.WriteLine(i.CompareTo(o));

            try
            {
                int k = (short)o;  // attempt to unbox

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
            }

            Console.ReadLine();
            
        }
    }
}
