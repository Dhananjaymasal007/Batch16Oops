using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{

    //protected access modifier
    //base class //parentclass //super class


    class Animal
    {
        //protected member
        protected string sound;
        
        //protected Method

        protected void Makesound()
        {
            Console.WriteLine($"Animal Makes Sound:{sound}");
        }

        
    }
    //Derived Class //Chield Class // Sub Class
    class Dog : Animal
    {

        public Dog()
        {
            sound = "Barks";
        }
        public void DisplaySound()
        {
            Makesound();
        }


    }

    class Cat :Animal
    {

        public Cat() {
            sound ="xyx";

        
        }
        public void DisplaySound() 
        
        {

            Makesound();
        
        }
    }

     class ProtectedExample
    {
        

    }
}
