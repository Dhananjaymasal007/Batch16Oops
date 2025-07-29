using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    public class PublicExampleTest
    {
        // Define Property

        public int PublicProperty { get; set; }

        //method
        public void Display()
        {
            System.Console.WriteLine("Public property value:"+ PublicProperty);
        }

        public void show()
        {
            Console.WriteLine("Hello");

        }
    }

        public class PublicExample
        {
            static void Main()
            {
                //creating object/instance for another class

                PublicExampleTest obj = new PublicExampleTest();

                obj.PublicProperty = 1;
                obj.Display();



            }

        }
    }

