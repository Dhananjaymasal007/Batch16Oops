using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{


    public delegate void Nofication();


    class MDelegate
    {
        public void StartingProcess()
        {
            Console.WriteLine("Process Started...........");
        }
        public void EndingProcess()
        {
            Console.WriteLine("Process Ended........");

        }
    }
    internal class MulticastDelegates
    {
        static void Main()
        {   
             // class object
             MDelegate MD = new MDelegate();


            //create the delegate instance

            Nofication Notify = MD.StartingProcess;
            MD.StartingProcess();

            Notify += MD.EndingProcess;
            MD.EndingProcess();

            Notify +=() => Console.WriteLine("All process are stopped");
            Notify();

        }

    }
}
