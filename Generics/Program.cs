using System;

namespace Generics
{



    public class Common<T> {

        private T data;
        
        public T value
        {

            // using accessors
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
    

    public class Common1 { 
    
        public  void Display<TypeOfValue>(string msg ,TypeOfValue value)

        {
            Console.WriteLine("{0}:{1}", msg, value);
            var number = new Nullable<int>(5);
            
            Console.WriteLine("Has Value?" + number.HasValue);
            Console.WriteLine("Has Value?" + number.GetValueOrDefault());
        }




    }


    class Program
    {
        static void Main(string[] args)
        {
            Common<string> obj1 = new Common<string>();
            obj1.value = "test data";
            Common<int> obj2 = new Common<int>();
            obj2.value = 34;
            Console.WriteLine(obj1.value);
            Console.WriteLine(obj2.value);
            

            Common1 obj3 = new Common1();
            obj3.Display<int>("int", 1);
            obj3.Display<char>("character", 'h');
            Console.ReadLine();


        }
    }
}
