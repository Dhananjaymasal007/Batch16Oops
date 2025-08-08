using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    //base class
    class Employee
    {
        public virtual void Role()
        {
            Console.WriteLine("I am a employee");
        }

    }
    //sealed class  that prevent inheritance
   sealed  class Manager : Employee
    {

        public override void Role()
        {
            Console.WriteLine("I am a manager");

        }
    }

   //// attempting to  inherit form sealed calss- will cause compil erro
   // class TeamLead : Manager
   // {


   // }


    internal class SealedClass
    {

        static void Main()
        {
            Manager mgr = new Manager();
            mgr.Role(); 
        }
    }
}
