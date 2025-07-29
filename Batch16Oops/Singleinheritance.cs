using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    class Vehical  //Base Class  or parent class or super class
    {
        public string Brand { get; set; }
        public void Drive()
        {
            Console.WriteLine($"{Brand} is Driving");

        }
    }

    class Car : Vehical    //Derived Class Or child class or sub class
    {
        public int NumberofDoors {  get; set; }

        public void ShowCarInfo()
        {
            Console.WriteLine($"{Brand} car has {NumberofDoors} door");
        }

    }

    internal class Singleinheritance
    {
        static void Main()
        {

            Car mycar = new Car();
            mycar.Brand = "HUNDAI";
            mycar.NumberofDoors = 4;
            mycar.Drive();
            mycar.ShowCarInfo();



        }
    }
}
