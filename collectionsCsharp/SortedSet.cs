using System;
using System.Collections.Generic;


namespace collectionsCsharp
{
    class SortedSet
    {
        public static void sortedset(){
            var names = new SortedSet<string>() {"john","tiny","mike" };
            names.Add("john");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();


        }
    }
}
