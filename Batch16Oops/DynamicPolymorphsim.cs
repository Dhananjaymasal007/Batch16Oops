using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{

    //dynamic polymorphism OR Method Overridding OR Runtime 
    //Metho0d name same  parameter also same but in different classes it follows parent chield relationship
    //Base Class // parent class

    class Shape
    {
        
        public  virtual void Draw()
        {
            Console.WriteLine("Drawing shape");
        }

    }
    //Derived Class //cheild class
    class Circle : Shape
    {

        public override void Draw()
        {
            Console.WriteLine("Drawing Circle" );
        }
    }
    //Derived class //child class
    class rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
    internal class DynamicPolymorphsim
    {
        static void Main()
        {
            //object creation 
            Shape shape1 = new Shape(); ;
            Shape shape2 = new Circle();
            rectangle shape3 = new rectangle();
            
            //calling method

            shape1.Draw();
            shape2.Draw();
            shape3.Draw();


        }


    }
}
