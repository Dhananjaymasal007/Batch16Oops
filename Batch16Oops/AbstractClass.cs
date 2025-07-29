using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{


    //abstract class
    public abstract class Aniaml 
    {
        public int a, b;

        // abstract method(NO Implemention)
        public abstract void MakingSound();

        //non abstrat method(it has implementation)

        public void Eat()
        {
            Console.WriteLine("Animal is eating");

        }
    }

    //derived class
    public class Dog1 :Aniaml
    {

        public override void MakingSound()
        {
            Console.WriteLine("Dog Barks");
        }
    }


    public class Cat1 : Aniaml
    {
        //implementation of abstract class
        public override void MakingSound()
        {
            Console.WriteLine("Cat is Meows");
        }

    }

    internal class AbstractClass
    {

        static void Main()
        {

           // Aniaml aa = new Aniaml();
           //creating objects for derived classes

            Dog1 dog = new Dog1();

            Cat1 cat = new Cat1();

            //call method
            dog.MakingSound();
            dog.Eat();

            cat.MakingSound();
            cat.Eat();



        }

    }
}
