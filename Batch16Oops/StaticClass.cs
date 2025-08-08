using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    static class CatWorld
    {
        public static int NumberOfCats;
        public static int TotalCatNaps;


        static CatWorld()
        { 
            NumberOfCats = 50;
            TotalCatNaps = 20;
        }
        public static void AddCats()
        {
            NumberOfCats++;
            Console.WriteLine($" New cat is joined:{NumberOfCats}");
        }
    }

    internal class StaticClass
    {
        static void Main()
        {
            CatWorld.AddCats();
        }
    }
}
