using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    class Myshape // Base class or parent class
    {

        public void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }

    }

    class mycircle : Myshape  // cheild class
    {

        public void DrawCricle()
        {
            Console.WriteLine("Drawing Cicle");
        }
    }
    class Myrectangle : Myshape  //cheild 
    {
        public void DrawingRectangle()
        {
            Console.WriteLine("Drawing Rectangele");
        }

    }
    class MyTrangle : Myshape //cheild
    {
        public void DrawingTrangle()
        {
            Console.WriteLine("Drawing Trangle");
        }

    }

    internal class Hirarcalinheritance
    {
        static void Main()
        {
            mycircle c = new mycircle();
            c.Draw();
            c.DrawCricle();

           Myrectangle R = new Myrectangle();
            R.Draw();
            R.DrawingRectangle();


            MyTrangle T = new MyTrangle();
            T.Draw();
            T.DrawingTrangle();
           // T.dr

        }
    }
}
