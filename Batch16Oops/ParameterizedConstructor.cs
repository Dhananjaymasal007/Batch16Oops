using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch16Oops
{
    public class PArameterizedConstructor
    {
        public string name { get; set; }
        public int age { get; set; }
        public PArameterizedConstructor(string Name, int Age)
        {
            name = Name;
            age = Age;

        }
        public void displayinfo()
        {


            Console.WriteLine($"Parameter constructor field Name={name}");
            Console.WriteLine($"Age{age}");

        }
    }

    internal class ParameterizedConstructor
    {
        static void Main()
        {
            PArameterizedConstructor obj = new PArameterizedConstructor("Mayur", 22);
            obj.displayinfo();
        }
    }


}

