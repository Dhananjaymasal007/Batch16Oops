using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal class Arrays
    {
        static void Main()
        {
            //option one 
            string[] mobile = new string[4];
            mobile[0] = "Apple";
            mobile[1] = "Sansung";
            mobile[2] = "Nokia";
            mobile[3] = "OnePlus";

            //option two
            //string[] mobiles = { "Apple", "Sansung", "nokia", "OnePlues", "Vivo" };


            //accing the element from the above array.


            for (int i = 0; i < mobile.Length; i++)
            {
                Console.WriteLine("Mobile Names:"+ mobile[i]);
            }


            //multidimentional array

            int[,] matrix = new int[,]
            {
                { 1,2,3, },
                { 4,5,6, },
                { 7, 8,9 }
             };


            //accessing values from multidimentional arrays
            Console.WriteLine("Element at (0,0):"+matrix[0, 0]);
            Console.WriteLine("Element at (1,2):"+matrix[1, 2]);



            //Jagged Array

            //declaration of jagged array

            int[][] jaggedarry = new int[][]
            {
                new int []{ 1,2,}, 
                new int []{ 3,4,5,},
                new int []{ 6,7,8,9,10,11}
            };
                
            //accessing element form the jagged array
            Console.WriteLine("Elements at [0][1]"+ jaggedarry[0][1]);

            for (int i = 0;i < jaggedarry.Length;i++)
            {
                for (int j = 0; j< jaggedarry[i].Length;j++)
                {
                    Console.Write(jaggedarry[i][j] + " ");
                }
                Console.WriteLine();
            }


            //Revese string

            string str = "welcome to";

            Console.WriteLine(str);

            char[] charArray = str.ToCharArray();
            char[] reversedArray = new char[charArray.Length];

            for ( int i=0; i<charArray.Length;i++ )
            {
                reversedArray[i] = charArray[charArray.Length -1-i];
            }

            string reversedstr = new string(reversedArray);
            Console.WriteLine(reversedstr);





        }


    }
}
