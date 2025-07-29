using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    class PrivateClass
    {
        public int PublicProperty { get; set; }
        //private property
        private int privatefield;
        
        //private method
        private void setfield(int value)
        {
            privatefield = value;

        }

    }

    internal class PrivateExample
    {

        private int privatefiel = 2;

        static void Main()
        {
            //PrivateClass obj = new PrivateClass();
            //obj.PublicProperty = 2;
            //obj.privatefield =2;
            // Console.WriteLine("private field:"+ privatefiel);

            //Dog dg = new Dog();
            //dg.DisplaySound();


            Internal inter = new Internal();
            inter.Sound = "Hello test";
            inter.MakeSound();






    }



}

    
}
