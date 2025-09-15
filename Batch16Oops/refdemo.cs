using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class refdemo
    {
        public  static  void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
          
        }
        public static void Main()
        { int a=100;
            int b=200;
            Console.WriteLine(a+b);
            swap(ref a, ref b);
            Console.WriteLine($"swap {a},{b}");
        }
    }
}
