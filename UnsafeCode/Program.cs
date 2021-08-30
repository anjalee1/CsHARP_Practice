using System;
struct Demo
{
    public int M, N;
}

namespace UnsafeCode
{
    class Program
    {
        static unsafe void PrintDemo(Demo* pDemo)
        {
            Console.WriteLine((*pDemo).N + " " + (*pDemo).M);
            Console.WriteLine(pDemo->N + " " + pDemo->M);
        }
        

        static unsafe void Square(int* pn)
        {
            *pn = *pn * *pn;
        }

        static unsafe void Print(int* par, int len)
        {
            for (int i = 0; i < len; i++)

            {
                Console.WriteLine(*(par + i) + " " + par[i]);
            }
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
            int[] ar = { 1, 2, 3, 4, 5 };/* allocated on heap*/
            unsafe
            {
                fixed (int* par = ar)
                {
                    Print(par, ar.Length);
                }
                int* par1 = stackalloc int[n];/* allocated on stack */
                Console.WriteLine(par1[100]); /* allocated on stack */
            }
            Demo D;
            D.N = 10;
            D.M = 20;
            unsafe
            {
                PrintDemo(&D);
            }
        }
    }
}