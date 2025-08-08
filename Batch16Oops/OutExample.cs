using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class outexample
    {

        static void Main()
        {
            int a = 10,b;
            string str = "Mayur";
           
            string name;
            InitializationValue( a, str, out b,out name);
            Console.WriteLine($"Out parameter value:{a} and name:{str}");
        }public static void InitializationValue(int a,string str ,out int b,out string name)
        {
           b  = a;
            name=str;

        }

    }
}
