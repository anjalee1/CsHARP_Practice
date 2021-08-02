using System;
using System.Collections.Generic;
using System.Text;

namespace collectionsCsharp
{
    class Dictionary
    {
        public static void Dict()
        {
            //create dictionary and add vakues to it
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "data1");
            dict.Add(2, "data2");
            dict.Add(3, "data3");
            foreach(KeyValuePair<int,string> kp in dict)
            {
                Console.WriteLine("key is " + kp.Key + " : value is " + kp.Value + "  ");
            }
            Console.WriteLine();

            Dictionary<string, string> Countries = new Dictionary<string, string>() { {"india" , "1"}, {"france","2" }, { "germany","3"} };

            foreach(var kp in Countries)
            {
                Console.WriteLine("key is " + kp.Key + " : value is  " + kp.Value + "  ");
            }
            Console.WriteLine();

            //acccess elements of dictionary

            if(Countries.ContainsKey("1"))

            {

                Console.WriteLine(Countries["1"]);
            }

            Console.WriteLine("Key is not AVAILABLE");

            

            if(Countries.TryGetValue("france",out string val))
            {
                Console.WriteLine(val);
            }

            //update dictionary

            if(Countries.ContainsKey("france"))
            {
                Countries["france"] = "new val";
            }

            foreach (var kp in Countries)
            {
                Console.WriteLine("key is " + kp.Key + " : value is  " + kp.Value + "  ");
            }
            Console.WriteLine();

            //remove elements in dictionary
            if(Countries.ContainsKey("france"))
            {
                Countries.Remove("france");
            }
            dict.Clear();
            foreach (KeyValuePair<int, string> kp in dict)
            {
                Console.WriteLine("key is " + kp.Key + " : value is " + kp.Value + "  ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }

        
    }

