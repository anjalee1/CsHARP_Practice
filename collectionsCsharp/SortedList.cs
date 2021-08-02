using System;
using System.Collections.Generic;
using System.Text;

namespace collectionsCsharp
{
    class SortedList
    {

        public static void Sortedlist()
        {
            var dataList = new SortedList<int, string> { { 3, "data1" },{ 1,"cdata2"},{ 2,"adata3"} };
            Console.WriteLine(dataList);

            dataList.RemoveAt(0);
            dataList.Remove(3);
            dataList.Add(6,"DATA6");
            dataList.Add(7, "DATA7"); 
            dataList.Add(8, "DATA8");


            foreach (KeyValuePair<int,string> kp in dataList )
            {
                Console.WriteLine("key : {0}, value : {1}", kp.Key ,kp.Value);
                Console.Write("");
            }
           
            for(int i =0; i < dataList.Count; i++)
            {
                Console.WriteLine("Key : {0} and Value : {1}", dataList.Keys[i], dataList.Values[i]);
            }
            Console.WriteLine(dataList.Keys);
            Console.WriteLine(dataList.Values[0]);

            Console.ReadKey();
        }
    }
}
