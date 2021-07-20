using System;
using System.Collections.Generic;
using System.Text;

namespace collectionsCsharp
{
    class List
    {
        public static void list()
        {
            var names = new List<string>() { "hawking","feynmann","marie"};
            names.Add("tesla");
            names.Insert(2, "data");
            
            foreach(string name in names)
            {
               // Console.WriteLine(name + " ");
                Console.Write(name + " ");
            }

            Console.WriteLine(names.Capacity);
            names.Remove("data");


        }
    }
}
