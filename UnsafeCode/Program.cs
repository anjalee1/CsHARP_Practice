using System;

namespace UnsafeCode
{
    class Program
    {

        static int Square(int n)
        {
            return n * n;
        }

        static unsafe void Square(int* pn)
        {
            *pn = *pn * *pn;
        }
        static void Main(string[] args)
        {
            int n;
            n = 10;
            unsafe
            {
                Square(&n);
            }
            Console.WriteLine(n);
        }
    }
}
