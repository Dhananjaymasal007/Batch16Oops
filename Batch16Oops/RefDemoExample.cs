using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{

    internal class RefDemoExample
    {
        public static  void IncrementValue(ref int incvalue)
        {
            incvalue++;
        }

        static void Main()
        {
            
            int incvalue = 10;
            Console.WriteLine($"before increment value:{incvalue}");

            IncrementValue(ref incvalue);
            Console.WriteLine($"after incerment value:{incvalue}");



        }
    }
}
