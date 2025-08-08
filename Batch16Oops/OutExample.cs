using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class OutExample
    {

        static void Main()
        {
            //declare variable in out
            int result1;
            int result2,result3,result4;
            int x = 30, y = 20;

            //call method with out parameter

            BasicOperations(x, y, out result1, out result2,out  result3, out result4);

            //display 
            Console.WriteLine("Addition is : "+ result1);

            Console.WriteLine("Substration is : "+ result2);

            Console.WriteLine("Multiplication is : "+ result3);


            Console.WriteLine("Division is : "+ result4);
        }
        static void BasicOperations(int x,int y,out int addition, out int Substraction,out int Multiplication, out int Division)
        {

            addition  =  x + y;
            Substraction = x-y;
            Multiplication = x * y;
            Division = x / y;

        }



    }
}
