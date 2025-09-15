using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    public class DEfaultconstructor
    {
        public DEfaultconstructor()
        {
            int value;
        }
        public void Display()

        {
            int value = 10000;
            Console.WriteLine($"Default constructor value = {value}");
        }
    }
        internal class Defaultconstructor
        {
            static void Main()
            {
                DEfaultconstructor obj = new DEfaultconstructor();
                obj.Display();


            }
        }
    }
