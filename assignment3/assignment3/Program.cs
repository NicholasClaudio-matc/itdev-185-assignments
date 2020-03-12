using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceList<string, double> item1 = new PriceList<string, double>("Bread", 2.54);
            PriceList<string, double> item2 = new PriceList<string, double>("Milk", 2.78);
            PriceList<string, double> item3 = new PriceList<string, double>("Eggs", .98);
            PriceList<string, double> item4 = new PriceList<string, double>("Apples", 3.99);

            item1.Print();
            item2.Print();
            item3.Print();
            item4.Print();

            Console.ReadKey();
        }
    }
}
