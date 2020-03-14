using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Program
    {
        static void Main(string[] args)
        {

            Heroes super = new Heroes();


            foreach (string value in super.SuperHeroes())
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
            
        }
    }
}
