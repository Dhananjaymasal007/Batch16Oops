using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    //static clas
    static class Product
    {
        //static member 
        public static int produdtid;
        public static string productname;
        public static int productprice;

        //static constructor
        static Product()
        {
            produdtid =100;
            productname = "test";
            productprice = 200;
        }
        //static method
        public static void GetProductDetails()
        {
            Console.WriteLine("product id :{0}", produdtid);
            Console.WriteLine("product Name :{0}", productname);
            Console.WriteLine("product Price :{0}", productprice);

        }

        public static void getDiscount()
        {
            int d_aount = productprice/10;
            Console.WriteLine("Your Discount amount is {0}",d_aount);
            Console.WriteLine("Total amount of product : {0}", (productprice-d_aount));

        }
    }
    internal class StaticClasses
    {
        static void Main()
        {
            Product.GetProductDetails();
            Product.getDiscount();
            Console.ReadLine();

        }

    }
}
