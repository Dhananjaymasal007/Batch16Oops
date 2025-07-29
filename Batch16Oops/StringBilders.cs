using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class StringBilders
    {

       static void Main()
        {
            //string 
            string str = "Hello world";
            Console.WriteLine(str);

            str  = "Test";
            Console.WriteLine(str);

            string Firstname = "Abhishek";
            string Lastname = "Shitole";
            string FullName = Firstname + Lastname;
            Console.WriteLine(FullName);


            ///string builder
            StringBuilder sb = new StringBuilder();
            sb.Append("My Name ");
            sb.Append("is ");
            sb.Append("Abhishek "); //Mr.
            sb.Append("Shitole ");


            //insert  value oto string builder in specific index

            sb.Insert(11, "Mr.");

            //replace value in specfic index using string builder
            sb.Replace("Shitole", "Patil");


            Console.WriteLine(sb.ToString());
           sb.Clear();



            //boxing - it is a process of converting value type  to object type

            int i = 10;  // value type 
            object y = i; // boxing -- Implicit conversion


            //unboxing - it is process of converting object type to value type

            object o = 10;
            int  j = (int)o; // performing unboxing --  this is explicit conversion






            



















        }


    }
}
