using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    public delegate void calculatee(int a, int b);

    class Calculater1
    {
        public void add(int a, int b)
        {
            Console.WriteLine($"addition of two number=:{a + b}");
        }
        public void sub(int a, int b)
        {
            Console.WriteLine($"substraction of two number=:{a - b}");
        }
        public void multi(int a, int b)
        {
            Console.WriteLine($"multiply of two number=:{a * b}");
        }
        public void divide(int a, int b)
        {
            Console.WriteLine($"divide of two number=:{a/b}");
        }
    }
    internal class MultiCastDelegate
    {
        static void Main()
        {
            Calculater1 md = new Calculater1();

            calculatee c2= md.add;
            c2+= md.sub;
            c2 += md.multi;
            c2 += md.divide;
            c2(11, 33);
            
        }
    }
}
