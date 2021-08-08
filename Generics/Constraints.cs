using System;
using System.Collections.Generic;
using System.Text;
//Generics with constraints

//types of contsrains
//   where T: I comparable
//    where T: Products (where T is product or any of its subsclass or children)
//    where T: struct (if T should be value type then keyword struct is used)
//    where T : class(ThreadStaticAttribute is a class as in it has to be a reference type)
//    where T: new()(T  is an object which has default constructor)

namespace Generics
{
    class Constraints<T> where T : IComparable, new()
    {
      public int Max(int a ,int b)
        {
            return a > b ? a : b;
        }

        public void doSomething(T value)
        {
            var obj = new T();
        }
     public T Max(T a , T b )               // T Max<T>(T a, T b) where T: IComparable
        {  
            return a.CompareTo(b) >0? a : b;


        }
    }


}
