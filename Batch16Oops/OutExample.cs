using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class OutExample
    {
        static void Main()
        {
            int a = 10;
            string name = "Mayur";
            IntializeValue(out a,out name);
            Console.WriteLine(a);

        }
        public  static void IntializeValue(out int a, out string  name);
        {

        }
    }
}