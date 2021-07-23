using System;
using System.Collections.Generic;
using System.Text;

namespace basicCsharp
{
    class Array
    {


        public static int[,] ar1 = new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
       
        public static void MultiArray()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ar1[i, j] + " ");
                }
                Console.WriteLine();//new line at each row  
            }
        }
    }
}
