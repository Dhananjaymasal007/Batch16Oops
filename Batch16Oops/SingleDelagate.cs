using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    public delegate void add(int a,int b);
    public delegate void sub(int a,int b);
    public delegate void multi(int a,int b);
    public delegate void divide(int a,int b);
    class Calculater
    {
       public  void addnumber(int a,int b)
        {
            Console.WriteLine("..........Single Delegate.......... ");
            Console.WriteLine($"addition of two number =: {a + b}");
        }
        public void subnumber(int a,int b) 
        {
            Console.WriteLine($"subtraction of two number =: {a - b}");
        }
        public void multiplynumber(int a,int b)
        {
            Console.WriteLine($"Multiplication of two number =: {a * b}");

        }
        public void divide(int a, int b)
        {
            Console.WriteLine($"Divide of two number =: {a / b}");
        }
    }
    internal class SingleDelagate
    {
        static void Main()
        {
            Calculater cr = new Calculater();
            cr.addnumber(11,23);
           add a = (cr.addnumber);
            cr.subnumber(11,23);
            sub s= (cr.subnumber);
            cr.multiplynumber(11,23);

            multi m= (cr.multiplynumber);
            cr.divide(11,23);
            divide d = (cr.divide);


        }
    }
}
