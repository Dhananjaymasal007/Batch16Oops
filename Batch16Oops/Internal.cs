using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class Internal
    {
        //interenal member or property or field
        internal string Sound = "test";

        //internal method

        internal void MakeSound()
        {
            Console.WriteLine($"Animal Makes Sound:{Sound}");
        }



    }
}
