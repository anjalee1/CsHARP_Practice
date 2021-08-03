using System;


namespace basicCsharp
{
    class ArrayClass
    {

        public static void Arrayclass()
        {
            string[] ar = new string[] { "data1", "data2", "data3" };
               //rank
            Console.WriteLine(ar.Rank);

            //SyncRoot
            //lock (ar.SyncRoot)
            //{
               
            //    foreach (Object i in ar)
            //        Console.WriteLine(i);
            //}


            //int index =Array.Find(ar, element => element.StartsWith("S",
            //               StringComparison.Ordinal));
            
            Console.ReadKey();
        }
    }
}
