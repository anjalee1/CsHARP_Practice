using System;

namespace oopsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Modifiers obj1 = new Modifiers("anjali");
            
            Console.WriteLine(obj1.data);
            obj1.Data1 = "new value";
            Console.WriteLine(obj1.Data1);
            Child obj2 = new Child("data1", " data2");
            Console.WriteLine(obj2.data);



        }
    }
}
