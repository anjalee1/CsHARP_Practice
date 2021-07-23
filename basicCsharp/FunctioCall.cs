﻿using System;
using System.Collections.Generic;
using System.Text;

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

    }
}
