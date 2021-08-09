using System;
delegate int NumberChange(int i);
namespace Delegates
{
    class Program
    {
        static int num  =10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }


        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {

            NumberChange nc;
            NumberChange nc1 = new NumberChange(AddNum);
            NumberChange nc2 = new NumberChange(MultNum);
            nc1(25);
            Console.WriteLine("value of num: {0}", getNum());
            nc2(34);
            Console.WriteLine("value of num: {0}", getNum());

            nc = nc1;
            nc += nc2;
            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc -= nc1;
            nc(5);

            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();

        }
    }
}
