using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class EnumExample
    {
        //Defining enum

        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }


        enum HttpStausCode
        {
            Ok = 200,
            Badrequest = 400,
            Unauthorized = 401,
            forbideen = 500,
            NotFound = 400

        }


        static void Main()
        {
      

            DayOfWeek today1 = DateTime.Now.DayOfWeek;


            Days today = Days.Saturday;

            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Today is sunday");
                    break;
                case Days.Monday:
                    Console.WriteLine("Today is monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Today is tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Today is wedensday");
                    break;
                case Days.Thursday:
                    Console.WriteLine("Today is thursday");
                    break;
                case Days.Friday:
                    Console.WriteLine("Today is friday");
                    break;
                
                                     
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Today is Sturday");
                    break;



                    
            }
            if (today == Days.Saturday  || today == Days.Sunday)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Its weekend");
            }
            HttpStausCode code = HttpStausCode.Ok;
            Console.WriteLine("HTTP status code"+ code);
            int codenumber = (int)code;
            Console.WriteLine("HTTP status code  number:"+ codenumber);





        }

    }
}
