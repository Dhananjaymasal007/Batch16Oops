using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{

    public class CopyConstructorExample
    {
        //parameter declaration
        public string name { get; set; }

        public int age { get; set; }

        public string nameNew { get; set; }
        public int ageNew { get; set; }


        //parameterized constructor
        public CopyConstructorExample(string Name, int Age)
        {
            name = Name;
            age = Age;
        }


        //copy constructor

        public CopyConstructorExample(CopyConstructorExample copyex)
        {
            nameNew  = copyex.name;
            ageNew = copyex.age;

        }


        public void Dsiplayinfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        public void DsiplayinfoNew()
        {
            Console.WriteLine($"Name: {nameNew}, Age: {ageNew}");
        }

    }
    
   internal class CopyConstuctor
        {
            static void Main()
            {
                // crating object with pass the value for parameterized constructor

                CopyConstructorExample obj = new CopyConstructorExample("Ajay", 25);
                obj.Dsiplayinfo();


            //copy constructor-- crating object
                CopyConstructorExample obj2 = new  CopyConstructorExample(obj);
            obj2.DsiplayinfoNew();



            }

        }
    }
