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

        public static void CheckedAndUnchecked()
        {


            int val = int.MaxValue;
            Console.WriteLine(val + 2);

            unchecked
            {
                int val1 = int.MaxValue;
                Console.WriteLine(val + 2);
            }
            try
            {
                checked
                {
                    int val2 = int.MaxValue;
                    Console.WriteLine(val + 2);
                }
            }
            catch(SystemException e)
            {
                Console.WriteLine(e);
            }
            Console.Write("Press 'E' to exit the process...");

            // here it asks to press "E" to exit
            // The key "E" is shown in the console 
            // output window because of "false"
            while (Console.ReadKey(false).Key != ConsoleKey.E)
            {
            }

            //Console.Write("\nPress 'E' to exit the process...");

            //// here it asks to press "E" to exit
            //// and the key "E" is not shown in
            //// the console output window
            //while (Console.ReadKey(true).Key != ConsoleKey.E)
            //{
            //}

            //Console.WriteLine("\npress any key to exit the process...");

            //// here we use "false" in the argument list
            //// when we press any key, the key will 
            //// displays in the console output window
            //Console.ReadKey(false);
        }


    }
}
