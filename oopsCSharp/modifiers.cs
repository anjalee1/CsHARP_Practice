using System;
using System.Collections.Generic;
using System.Text;

namespace oopsCSharp
{
    class Modifiers
    {
        public string data;

        public string Data1 //automatic properties(shorthand)
        { get; set; }

        //public string Data1
        //{
        //    get { return data1; }
        //    set { data1 = value; }
        //}


        public Modifiers(string dataval)
        {
            data = dataval;
        }


    }

    class Child : Modifiers
    {

        public string data1;

        public Child(string b , string d ) : base(d)
        {
            data1 = b;
        }


       
       
    }


}