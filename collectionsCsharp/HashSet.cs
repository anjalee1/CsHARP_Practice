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
        }
    }
}
