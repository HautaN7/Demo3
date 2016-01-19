using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create vehicle
            Vehicle audi = new Vehicle("Audi");
            audi.Speed = 150;
            audi.Tyres = 4;
            audi.PrintData();
            Console.ReadLine();

            // ToString
            Console.WriteLine(audi);
            Console.ReadLine();

        }
    }
}
