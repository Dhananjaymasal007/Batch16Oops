using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class Operators
    {
        static void Main()
        {
            // variable declaration
            int a = 10;
            int b = 10;

            //arithmatic operator
            Console.WriteLine("Arithmatic Operator");
            Console.WriteLine($"Addition : {a + b}");
            Console.WriteLine($"Substraction : {a-b}");
            Console.WriteLine($"Multiplication :{a*b}");
            Console.WriteLine($"Division : {a/b}");
            Console.WriteLine($"Mod : {a%b}");


            //Relational Operator OR Comparision operator
            Console.WriteLine("Comparision Operator");
            Console.WriteLine($"a==b:{a==b}");
            Console.WriteLine($"a!=b: {a!=b}");
            Console.WriteLine($"a<b: {a<b}");
            Console.WriteLine($"a>b: {a>b}");
            Console.WriteLine($"a<=b: {a<=b}");
            Console.WriteLine($"a>=b: {a>=b}");


            //logical operator
            bool x = false;
            bool y = true;
            Console.WriteLine("logical operator");
            Console.WriteLine($"x && y:{x&&y}");
            Console.WriteLine($"x || y:{x||y}");
            Console.WriteLine($"!x :{!x}");



        }



    }
}
