using System;
using System.Collections.Generic;
using System.Text;

namespace basicCsharp
{
    class Nullable
    {
        public static string? s2 = null;
        public static string s3 = "anjali";
        public string s4 = s2 ?? s3;
        public static void Nullabletype()
        {
            string? s1 = null;
            //Console.WriteLine(s1);
            Nullable<int> i = null;

            if (i.HasValue)

                Console.WriteLine(i);

            else
                Console.WriteLine("nullsable type variable");
            Console.WriteLine(i.GetValueOrDefault());
        }


        public static void NullableHelper()
        {
            int? i = null;
            int j = 10;
        


            if (i < j)
                Console.WriteLine("i < j");
            else if (i > 10)
                Console.WriteLine("i > j");
            else if (i == 10)
                Console.WriteLine("i == j");
            else

                Console.WriteLine("could not compare ");

            //console.writeline("could not compare");


            //    if(Nullable.Compare<int>(i,j) <0) # getting error with compare
            //        Console.WriteLine("i < j");
            //    else if (Nullable.Compare<int>(i, j) > 0)
            //        Console.WriteLine("i > j");
            //    else
            //        Console.WriteLine("i = j");
        }


    }


}