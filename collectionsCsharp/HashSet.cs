using System;
using System.Collections.Generic;
using System.Text;

namespace collectionsCsharp
{
    class HashSet
    {

        public static void hashSet()
        {
            var numbers = new HashSet<int>(){2,3,4 };
            numbers.Add(5);
            numbers.Add(3);
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            var number1= new HashSet<int> { 5,6,7 };
            numbers.UnionWith(number1);
            numbers.IntersectWith(number1);
           // numbers.ExceptWith(number1);
            
           
            
            number1.Clear();
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            foreach (int n in number1)
            {
                Console.Write(n);
                Console.WriteLine();
            }
            Console.Write(number1.Count);
            Console.ReadKey();

            

        }
    }
}
