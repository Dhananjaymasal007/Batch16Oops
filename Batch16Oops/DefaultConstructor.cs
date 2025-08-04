using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{

    public class DefaultCOnstructorExample
    {

        public int value;

        //default constructor

        public DefaultCOnstructorExample()
        {
            value = 10;

        }
        public void Display()
        {
            Console.WriteLine("Test " + value);

        }

    }
    internal class DefaultConstructor
    {
        static void Main()
        {

            //object createion -
            DefaultCOnstructorExample example = new DefaultCOnstructorExample();
            example.Display();
            //}

        }
    }
}
