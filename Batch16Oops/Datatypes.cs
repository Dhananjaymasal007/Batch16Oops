using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class Datatypes
    {
        //Datatype

        static void Main()
        {
            PublicExampleTest obj = new PublicExampleTest();

            obj.PublicProperty = 2;
            obj.Display();




            //Data type Declaration

            int age = 25;
            float price = 99.00f;
            double pi = 3.14159;
            decimal salary = 100000.50m;
            char grade = 'A';
            bool isActive = false;
            DateTime today = DateTime.Now;
            object data = 123;
            int? score = null;
            string name = "Sachin";



            //Print Datatype 

            Console.WriteLine("int:"+ age);
            Console.WriteLine("float:" +price);
            Console.WriteLine("double:" + pi);
            Console.WriteLine("decimal:" + salary);
            Console.WriteLine("char:" + grade);
            Console.WriteLine("bool:" + isActive);
            Console.WriteLine("DateTime:" + today);
            Console.WriteLine("int?:" + score);
            Console.WriteLine("string:" + name);










        }




    }
}
