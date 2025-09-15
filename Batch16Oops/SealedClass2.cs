using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    public class Baseclass
    {
        public  virtual void Display()
        {
            Console.WriteLine("use  a base class");
        }
    }
    sealed class Derived : Baseclass
    {
        public override void Display()
        {
          
            Console.WriteLine("use a derived class");
        }
    }
    internal class SealedClass2
    {
        static void Main()
        {
            Derived de = new Derived();
            de.Display();
        }
    }
}
