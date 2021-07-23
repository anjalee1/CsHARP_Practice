using System;


namespace basicCsharp
{
    class ExceHan
    {
        

        public static void ExceptionHandling() {
            int i=0;
             startingline: Console.WriteLine("program  " +i);
              Console.WriteLine();
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
                Console.WriteLine();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }


            try
            {
                Console.Write("Enter First Number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Second Number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.WriteLine();


            }
            // Console.ReadLine();

            catch (DivideByZeroException E)
            {
                Console.WriteLine(E.Message);
                Console.WriteLine();
            }

           
            try
            {
                Console.WriteLine("Enter a Number");

                int val = Convert.ToInt32(Console.ReadLine());
                Boolean t = Convert.ToBoolean(val);
                Console.WriteLine($"Converted value is : {t}");
                Console.WriteLine();


            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                Console.WriteLine();
            }


            static void checkAge(int age)
            {
                if (age < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");//The throw statement is used together with an exception class. 
                }
                else
                {
                    Console.WriteLine("Access granted - You are old enough!");
                    Console.WriteLine();
                }
            }

            checkAge(24);
            i++;

            goto startingline;
        }


    }
}
