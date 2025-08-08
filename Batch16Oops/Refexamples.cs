using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class Refexamples
    {
        //Ref Examples


        public static void SwapNumber(ref int a ,ref int b)
        {
           // int temp = a;
            //a = b;
            //b = temp;
            int c = a+b;

           

        }

        static void Main()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"Before swap values:x{a},y={b}");

            SwapNumber(ref a, ref b);


            Console.WriteLine($"After  swap values:x{a},y={b}");


        }


    }
}
