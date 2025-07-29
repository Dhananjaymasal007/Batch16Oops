using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{

    class A  //parent class or base class   // Grandparent 
    {
        public void Start()
        {
            Console.WriteLine("The vehical is started");
        }
    }
    class B  : A   // child class - parent class  (derived - base class) // parent 
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving");

        }

    }
    class C : B  //child class 
    {
        public void turbo()
        {
            Console.WriteLine("the car is in the turbo mode");

        }
    }


    internal class MultipleInheritance
    {
        static void Main()
        {
            C cls = new C();
            cls.Start(); // A
            cls.Drive();  // B
            cls.turbo(); // C

        }
    }
}
