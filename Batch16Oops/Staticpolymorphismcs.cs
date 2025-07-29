using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{

    //method name same class also same but different parameters
    //satic polymorphism OR method overloading OR compile time polymorphism


    class MathOperations
    {
        public int Add(int x, int y)
        {
            return x+y;

        }
        public double Add(double x, double y)
        {
            return x-y; ;

        }

    }


    internal class Staticpolymorphismcs
    {


        static void Main()
        {
            MathOperations ops = new MathOperations();
            //cakkung overload  methods

            int sum = ops.Add(1, 2);
            double sum1 = ops.Add(5.5, 2);

            Console.WriteLine("$ Sum of Integers : " + sum);
            Console.WriteLine(("$ sum of doubles:"+sum1));
        }

    }
}
