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
            Console.WriteLine(names.Contains("tesla"));

            var newnames = new List<string> { "data1", "data2" };
            newnames.AddRange(names);
            foreach(string newname in newnames)
            {
                Console.Write(newname + " ");
            }
            Console.WriteLine();
            foreach(string name in names)
            {
               // Console.WriteLine(name + " ");
                Console.Write(name + " ");
            }

            Console.WriteLine(names.Capacity);
            names.Remove("data");
            Console.ReadKey();


        }
    }
}
