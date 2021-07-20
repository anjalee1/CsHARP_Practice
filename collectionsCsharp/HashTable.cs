using System;
using System.Collections;
using System.Text;

namespace collectionsCsharp
{
    class HashTable
    {
        public static void hashtable()
        {
            Hashtable data = new Hashtable();
            data.Add("string", "anjali");
            data.Add(2, 3);
            data.Add('B', 'D');

            foreach(object obj in data.Keys)
            {
                Console.WriteLine($"{obj }: {data[obj]}");
            }
        }
    }
}
