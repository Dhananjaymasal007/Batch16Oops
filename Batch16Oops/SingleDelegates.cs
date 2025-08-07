using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    //[modifier] delegate retruntype | void <name>([parameterslist])
    //delegate declaration

    public delegate void AddDelegate(int a , int b);
    public delegate string DisplayDelegate(string str);


    class MyDelegates
    {

        public void AddNumbers(int a ,int b)
        {
            Console.WriteLine(a+ b);
        }
        public static string Display(string str)
        {
            return "Hello"+ str;

        }
       
    }
    internal class SingleDelegates
    {
        static void Main()
        {

            //calling  Delegates
            MyDelegates md = new MyDelegates(); //class object creation
            AddDelegate ad = new AddDelegate(md.AddNumbers);
            ad(10, 20);
           // md.AddNumbers(10, 20);


            DisplayDelegate dp = new DisplayDelegate(MyDelegates.Display);
            string str = dp("hello");
            Console.WriteLine(str); 




        }


    }
}
